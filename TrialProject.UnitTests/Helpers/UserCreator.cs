using TrialProject.API.Models;

namespace TrialProject.UnitTests.Helpers
{
    /// <summary>
    /// Creates users
    /// </summary>
    public static class UserCreator
    {
        /// <summary>
        /// Gets the user root.
        /// </summary>
        /// <returns>An object with multiple Users</returns>
        public static UserStatisticRoot GetUserRoot()
        {
            var userRoot = new UserStatisticRoot();

            var results = new Result[]
            {
                new()
                {

                },
                new()
                {

                },
                new()
                {

                },
                new()
                {

                },
                new()
                {

                },
                new()
                {

                },
                new()
                {

                },
            };

            userRoot.Results = results;
            return userRoot;
        }
    }
}
