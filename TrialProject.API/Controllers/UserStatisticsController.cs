using Microsoft.AspNetCore.Mvc;

namespace TrialProject.API.Controllers
{
    public class UserStatisticsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
