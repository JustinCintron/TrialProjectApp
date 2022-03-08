using Microsoft.AspNetCore.Mvc;
using TrialProject.API.Models;
using TrialProject.API.Services;

namespace TrialProject.API.Controllers
{
    /// <summary>
    /// The User Statistics controller with an endpoint for GetStatistics.
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Mvc.ControllerBase" />
    [Route("api/[controller]")]
    [ApiController]
    public class UserStatisticsController : Controller
    {
        private readonly IGenerateUserStatistics generateUserStatistics;

        /// <summary>
        /// Initializes a new instance of the <see cref="UserStatisticsController"/> class.
        /// </summary>
        /// <param name="generateUserStatistics">The generate statistics.</param>
        public UserStatisticsController(IGenerateUserStatistics generateUserStatistics)
        {
            this.generateUserStatistics = generateUserStatistics;
        }

        /// <summary>
        /// Gets the Json from the request body and returns formatted statistics with the format depending on the Accept header.
        /// </summary>
        /// <param name="userRoot">The Json value of the users.</param>
        [HttpGet]
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
