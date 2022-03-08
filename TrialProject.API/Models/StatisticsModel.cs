namespace TrialProject.API.Models
{
    /// <summary>
    /// The model containing all the statistics.
    /// This model will be serialized directly.
    /// </summary>
    public class StatisticsModel
    {
        /// <summary>
        /// Gets or sets the female percentage.
        /// </summary>
        /// <value>
        /// The female percentage.
        /// </value>
        public decimal FemalePercentage { get; set; }

        /// <summary>
        /// Gets or sets the first name a through m percentage.
        /// </summary>
        /// <value>
        /// The first name a through m percentage.
        /// </value>
        public decimal FirstNameAThroughMPercentage { get; set; }

        /// <summary>
        /// Gets or sets the last name a through m percentage.
        /// </summary>
        /// <value>
        /// The last name a through m percentage.
        /// </value>
        public decimal LastNameAThroughMPercentage { get; set; }
        /// <summary>
        /// Gets or sets the state of the people in each state.
        /// </summary>
        /// <value>
        /// The state of the people in each.
        /// </value>
        public List<PeopleStatePercentageModel> AllPeopleStatePercentage { get; set; } = new();

        /// <summary>
        /// Gets or sets the state of the females in each state.
        /// </summary>
        /// <value>
        /// The state of the people in each.
        /// </value>
        public List<PeopleStatePercentageModel> FemaleStatePercentage { get; set; } = new();

        /// <summary>
        /// Gets or sets the state of the males in each state.
        /// </summary>
        /// <value>
        /// The state of the people in each.
        /// </value>
        public List<PeopleStatePercentageModel> MaleStatePercentage { get; set; } = new();

        /// <summary>
        /// Gets or sets the age range percentages.
        /// </summary>
        /// <value>
        /// The age range percentages.
        /// </value>
        public List<AgeRangeModel> AgeRangePercentages { get; set; } = new();

    }
}
