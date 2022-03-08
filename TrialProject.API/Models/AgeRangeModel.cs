namespace TrialProject.API.Models
{
    /// <summary>
    /// Model for containing the age ranges and the percentages of users that fall in that range.
    /// </summary>
    public class AgeRangeModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AgeRangeModel"/> class.
        /// Empty constructor was necessary.
        /// </summary>
        public AgeRangeModel()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgeRangeModel"/> class.
        /// Constructor just to make assigning values look a bit cleaner.
        /// </summary>
        /// <param name="starting">The starting.</param>
        /// <param name="ending">The ending.</param>
        /// <param name="percentage">The percentage.</param>
        public AgeRangeModel(int starting, int ending, decimal percentage)
        {
            this.StartingAge = starting;
            this.EndingAge = ending;
            this.Percentage = percentage;
        }

        /// <summary>
        /// Gets or sets the starting age for this range.
        /// </summary>
        /// <value>
        /// The starting age.
        /// </value>
        public int StartingAge { get; set; }

        /// <summary>
        /// Gets or sets the ending age for this range.
        /// </summary>
        /// <value>
        /// The ending age.
        /// </value>
        public int EndingAge { get; set; }

        /// <summary>
        /// Gets or sets the percentage for this range.
        /// </summary>
        /// <value>
        /// The percentage of users.
        /// </value>
        public decimal Percentage { get; set; }
    }
}
