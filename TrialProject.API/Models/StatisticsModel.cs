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
    }
}
