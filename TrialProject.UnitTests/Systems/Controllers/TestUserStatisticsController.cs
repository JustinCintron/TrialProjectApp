using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TrialProject.API.Controllers;
using TrialProject.API.Models;
using Xunit;

namespace TrialProject.UnitTests.Systems.Controllers
{
    public class TestUserStatisticsController
    {
        /// <summary>
        /// Tests the Get method if no user data was given.
        /// </summary>
        /// <param name="users">The users.</param>
        [Theory]
        [InlineData(null)]
        public async Task Get_OnNoData_Returns400(UserStatisticRoot users)
        {

            var controller = new UserStatisticsController();

            var result = await controller.Get(users);

            result.Should().BeOfType<BadRequestResult>();
        }
        /// <summary>
        /// Tests the Get method if wrong data was sent.
        /// </summary>
        [Fact]
        public async Task Get_OnWrongData_Returns400()
        {

            var controller = new UserStatisticsController();

            var result = await controller.Get(new UserStatisticRoot());

            result.Should().BeOfType<BadRequestResult>();
        }
    }
}
