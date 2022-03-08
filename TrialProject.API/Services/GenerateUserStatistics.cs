using TrialProject.API.Models;

namespace TrialProject.API.Services
{
    /// <summary>
    /// The class that generates the statistics that are returned to the user.
    /// </summary>
    /// <seealso cref="TestingAPI.models.IGenerateUserStatistics" />
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

            return statistics;
        }
    }
}
