using FluentAssertions;
using System.Collections.Generic;
using System.Linq;
using TrialProject.API.Models;
using TrialProject.API.Services;
using TrialProject.UnitTests.Helpers;
using Xunit;

namespace TrialProject.UnitTests.Systems.Services
{
    public class TestGenerateUserStatistics
    {
        /// <summary>
        /// Tests the GetStatistics method if a null was given instead of a valid list.
        /// </summary>
        [Fact]
        public void GetStatistics_OnNullUsers_ReturnNewStatisticsModel()
        {
            var service = new GenerateUserStatistics();

            var result = service.GetStatistics(null);

            result.Should().BeEquivalentTo(new StatisticsModel());
        }

        /// <summary>
        /// Tests the GetStatistics method if an empty list was given.
        /// </summary>
        [Fact]
        public void GetStatistics_OnNoUsers_ReturnNewStatisticsModel()
        {
            var service = new GenerateUserStatistics();

            var result = service.GetStatistics(new List<IUserModel>());

            result.Should().BeEquivalentTo(new StatisticsModel());
        }

        /// <summary>
        /// Tests the GetStatistics method return type if valid data was given.
        /// </summary>
        [Fact]
        public void GetStatistics_OnValid_ReturnStatisticsModel()
        {
            var service = new GenerateUserStatistics();

            var results = UserCreator.GetUserRoot().Results;

            var result = service.GetStatistics(results.ToList().Cast<IUserModel>().ToList());

            result.Should().BeOfType<StatisticsModel>();
        }
    }
}
