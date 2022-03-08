using System.Collections.Generic;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Moq;
using TrialProject.API.Controllers;
using TrialProject.API.Models;
using TrialProject.API.Services;
using TrialProject.UnitTests.Helpers;
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

            var mockStatisticsService = new Mock<IGenerateUserStatistics>();

            var controller = new UserStatisticsController(mockStatisticsService.Object);

            var result = await controller.Get(users);

            result.Should().BeOfType<BadRequestResult>();
        }
        /// <summary>
        /// Tests the Get method if wrong data was sent.
        /// </summary>
        [Fact]
        public async Task Get_OnWrongData_Returns400()
        {

            var mockStatisticsService = new Mock<IGenerateUserStatistics>();

            var controller = new UserStatisticsController(mockStatisticsService.Object);

            var result = await controller.Get(new UserStatisticRoot());

            result.Should().BeOfType<BadRequestResult>();
        }
        /// <summary>
        /// Tests the GetStatistics method result type if valid data was sent.
        /// </summary>
        [Fact]
        public async Task Get_OnValidData_Returns200()
        {
            var mockStatisticsService = new Mock<IGenerateUserStatistics>();

            var controller = new UserStatisticsController(mockStatisticsService.Object);

            var users = UserCreator.GetUserRoot();

            var result = await controller.Get(users);

            result.Should().BeOfType<OkObjectResult>();

        }
        /// <summary>
        /// Tests the GetStatistics method value return type if valid data was sent.
        /// </summary>
        [Fact]
        public async Task Get_OnValidData_ReturnsStatisticsModel()
        {
            var mockStatisticsService = new Mock<IGenerateUserStatistics>();
            mockStatisticsService.Setup(service => service.GetStatistics(It.IsAny<List<IUserModel>>())).Returns(new StatisticsModel());

            var controller = new UserStatisticsController(mockStatisticsService.Object);

            var users = UserCreator.GetUserRoot();

            var result = (OkObjectResult)await controller.Get(users);

            result.Value.Should().BeOfType<StatisticsModel>();

        }

    }
}
