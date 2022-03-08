namespace TrialProject.API.Models
{
    public class PeopleStatePercentageModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PeopleStatePercentageModel"/> class.
        /// Parameter-less constructor because it is necessary.
        /// </summary>
        public PeopleStatePercentageModel()
        {
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="PeopleStatePercentageModel"/> class.
        /// Constructor to make assigning the values a little cleaner.
        /// </summary>
        /// <param name="state">The state.</param>
        /// <param name="percentage">The percentage.</param>
        public PeopleStatePercentageModel(string state, decimal percentage)
        {
            this.State = state;
            this.Percentage = percentage;
        }
        /// <summary>
        /// Gets or sets the state.
        /// </summary>
        /// <value>
        /// The state.
        /// </value>
        public string State { get; set; }
        /// <summary>
        /// Gets or sets the percentage.
        /// </summary>
        /// <value>
        /// The percentage.
        /// </value>
        public decimal Percentage { get; set; }
    }
}
