using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index([FromQuery] string name, [FromQuery] int Age, [FromQuery] bool HasDrivingLicence)
        {
            string username = name;
            if (string.IsNullOrEmpty(username))
                username = "Stranger";
            ViewData["User"] = username;

            ViewData["CarInfo"] = HasDrivingLicence?"Want to buy a car?":"Wanna bicycle?";

            ViewData["AdultInfo"] = Age>=18?"More than 18.":"Less than 18";

            //return View();

            if (Age >= 18)
                return View("Above");
            else
                return View("Under");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
