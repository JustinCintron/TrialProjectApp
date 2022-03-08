using Microsoft.AspNetCore.Mvc;
using TrialProject.API.Models;
using TrialProject.API.Services;

namespace TrialProject.API.Controllers
{
    public class UserStatisticsController : Controller
    {
        private readonly IGenerateUserStatistics generateUserStatistics;

        public UserStatisticsController(IGenerateUserStatistics generateUserStatistics)
        {
            this.generateUserStatistics = generateUserStatistics;
        }
        public async Task<IActionResult> Get([FromBody] UserStatisticRoot userRoot)
        {

            if (userRoot == null || !userRoot.Results.Any())
            {
                return BadRequest();
            }

            var statistics = this.generateUserStatistics.GetStatistics(userRoot.Results.ToList().Cast<IUserModel>().ToList());

            return Ok(statistics);
        }
    }
}
