using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class CarController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(CarViewModel viewModel)
        {
            this.ViewBag.Message = $"{viewModel.Brand} {viewModel.Model} added to favorites!";
            return View("Info", viewModel);
        }
        [HttpGet]
        [Route("/browse")]
        public IActionResult List()
        {
            List<CarViewModel> list = new List<CarViewModel>();
            list.Add(new CarViewModel() { Brand="Kia", Model="Ceed", TopSpeed=180 });
            list.Add(new CarViewModel() { Brand = "Fiat", Model = "500", TopSpeed = 190 });
            list.Add(new CarViewModel() { Brand = "BMW", Model = "X5", TopSpeed = 250 });
            return View(list);
        }
    }
}
