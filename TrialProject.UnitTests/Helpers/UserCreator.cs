using System;
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
                    Name = new Name {
                        First = "Nellie",
                        Last = "Lopez",
                        Title = "Mrs"
                    },
                    Location = new Location {
                        City = "Worcester",
                        Country = "United States",
                        State = "California"
                    },
                    Gender = Gender.Female,
                    Dob = new Dob {
                        Age = 64,
                        Date = DateTime.Parse("1958-06-19T01:48:04.445Z")
                    }
                },
                new()
                {
                    Name = new Name {
                        First = "Vickie",
                        Last = "Brooks",
                        Title = "Ms"
                    },
                    Location = new Location {
                        City = "North Charleston",
                        Country = "United States",
                        State = "California"
                    },
                    Gender = Gender.Female,
                    Dob = new Dob {
                        Age = 72,
                        Date = DateTime.Parse("1950-12-14T09:44:16.607Z")
                    }
                },
                new()
                {
                    Name = new Name {
                        First = "Zoey",
                        Last = "Miles",
                        Title = "Miss"
                    },
                    Location = new Location {
                        City = "Grapevine",
                        Country = "United States",
                        State = "California"
                    },
                    Gender = Gender.Female,
                    Dob = new Dob {
                        Age = 27,
                        Date = DateTime.Parse("1995-06-16T19:21:11.729Z")
                    }
                },
                new()
                {
                    Name = new Name {
                        First = "Lorraine",
                        Last = "Vasquez",
                        Title = "Miss"
                    },
                    Location = new Location {
                        City = "Helena",
                        State = "North Carolina",
                        Country = "United States"
                    },
                    Gender = Gender.Female,
                    Dob = new Dob {
                        Age = 61,
                        Date = DateTime.Parse("1961-04-19T03:22:27.535Z")
                    }
                },
                new()
                {
                    Name = new Name {
                        First = "Carla",
                        Last = "Long",
                        Title = "Mrs"
                    },
                    Location = new Location {
                        City = "Chandler",
                        State = "Georgia",
                        Country = "United States"
                    },
                    Gender = Gender.Female,
                    Dob = new Dob {
                        Age = 70,
                        Date = DateTime.Parse("1952-08-17T16:29:35.408Z")
                    }
                },
                new()
                {
                    Name = new Name {
                        First = "Elmer",
                        Last = "Anderson",
                        Title = "Mr"
                    },
                    Location = new Location {
                        City = "Durham",
                        Country = "United States",
                        State = "Maryland"
                    },
                    Gender = Gender.Male,
                    Dob = new Dob {
                        Age = 60,
                        Date = DateTime.Parse("1962-01-14T18:13:15.521Z")
                    }
                },
                new()
                {
                    Name = new Name {
                        First = "Adrian",
                        Last = "Ortiz",
                        Title = "Mr"
                    },
                    Location = new Location {
                        City = "Surprise",
                        Country = "United States",
                        State = "Utah"
                    },
                    Gender = Gender.Male,
                    Dob = new Dob {
                        Age = 60,
                        Date = DateTime.Parse("1962-02-07T14:12:06.978Z")
                    }
                },
            };

            userRoot.Results = results;
            return userRoot;
        }
    }
}
