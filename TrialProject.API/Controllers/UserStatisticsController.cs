using Microsoft.AspNetCore.Mvc;
using TrialProject.API.Models;

namespace TrialProject.API.Controllers
{
    public class UserStatisticsController : Controller
    {
        public async Task<IActionResult> Get([FromBody] UserStatisticRoot userRoot)
        {

            if (userRoot == null || !userRoot.Results.Any())
            {
                return BadRequest();
            }



            return Ok();
        }
    }
}
