namespace TrialProject.API.Models
{
    /// <summary>
    /// Contains the Results (the users) used for deserialization.
    /// </summary>
    public class UserStatisticRoot
    {
        /// <summary>
        /// Gets or sets the results (the users).
        /// </summary>
        /// <value>
        /// The results.
        /// </value>
        public Result[] Results { get; set; } = Array.Empty<Result>();
    }
}
