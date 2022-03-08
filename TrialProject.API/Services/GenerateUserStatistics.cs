using TrialProject.API.Models;

namespace TrialProject.API.Services
{
    /// <summary>
    /// The class that generates the statistics that are returned to the user.
    /// </summary>
    /// <seealso cref="TrialProject.API.Services.IGenerateUserStatistics" />
    public class GenerateUserStatistics : IGenerateUserStatistics
    {
        /// <summary>
        /// Gets the statistics based on the given users.
        /// </summary>
        /// <param name="userModels">The users.</param>
        /// <returns>A StatisticsModel that contain all the statistics.</returns>
        public StatisticsModel GetStatistics(List<IUserModel> userModels)
        {
            var statistics = new StatisticsModel();

            if (userModels == null || userModels.Count == 0)
            {
                return statistics;
            }

            var numberOfFemales = userModels.Count(x => x.Gender == Gender.Female);
            var numberOfUsers = userModels.Count;

            statistics.FemalePercentage = Math.Round(numberOfFemales * 100M / numberOfUsers, 2);

            this.generateStateStatistics(userModels, statistics, numberOfUsers);

            statistics.FirstNameAThroughMPercentage = Math.Round(userModels.Count(x => x.FirstName[0] >= 'A' && x.FirstName[0] <= 'M') * 100M / numberOfUsers, 2);
            statistics.LastNameAThroughMPercentage = Math.Round(userModels.Count(x => x.LastName[0] >= 'A' && x.LastName[0] <= 'M') * 100M / numberOfUsers, 2);

            this.generateAgeStatistics(userModels, statistics, numberOfUsers);

            return statistics;
        }

        /// <summary>
        /// Generates the age statistics.
        /// </summary>
        /// <param name="users">The users.</param>
        /// <param name="statistics">The statistics.</param>
        /// <param name="numberOfUsers">The number of users.</param>
        private void generateAgeStatistics(IReadOnlyCollection<IUserModel> users, StatisticsModel statistics, int numberOfUsers)
        {
            var ageRanges = new List<(int starting, int ending)> {
                (0, 20),
                (21, 40),
                (41, 60),
                (61, 80),
                (81, 90),
                (91, 100),
                (100, int.MaxValue)
            };

            foreach (var (starting, ending) in ageRanges)
            {
                var agePercentage = Math.Round(users.Count(x => x.Age >= starting && x.Age <= ending) * 100M / numberOfUsers, 2);

                statistics.AgeRangePercentages.Add(new AgeRangeModel(starting, ending, agePercentage));
            }
        }

        /// <summary>
        /// Generates the state statistics.
        /// </summary>
        /// <param name="users">The users.</param>
        /// <param name="statistics">The statistics.</param>
        /// <param name="numberOfUsers">The number of users.</param>
        private void generateStateStatistics(IEnumerable<IUserModel> users, StatisticsModel statistics, int numberOfUsers)
        {
            //Group by state then order by the count of each group and finally take the top 10.
            var topPopulousStates = users.GroupBy(x => x.State).OrderByDescending(x => x.Count()).Take(10);

            foreach (var state in topPopulousStates)
            {
                statistics.AllPeopleStatePercentage.Add(new PeopleStatePercentageModel(state.Key, Math.Round(state.Count() * 100M / numberOfUsers, 2)));
                statistics.FemaleStatePercentage.Add(new PeopleStatePercentageModel(state.Key, Math.Round(state.Count(x => x.Gender == Gender.Female) * 100M / numberOfUsers, 2)));
                statistics.MaleStatePercentage.Add(new PeopleStatePercentageModel(state.Key, Math.Round(state.Count(x => x.Gender == Gender.Male) * 100M / numberOfUsers, 2)));
            }

            //Sorted (ordered) by descending value.
            statistics.AllPeopleStatePercentage = statistics.AllPeopleStatePercentage.OrderByDescending(x => x.Percentage).ToList();
            statistics.FemaleStatePercentage = statistics.FemaleStatePercentage.OrderByDescending(x => x.Percentage).ToList();
            statistics.MaleStatePercentage = statistics.MaleStatePercentage.OrderByDescending(x => x.Percentage).ToList();
        }

    }
}
