using Microsoft.AspNetCore.Mvc;
using FutureValue.Models;
namespace FutureValue.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Name = "Maksim";
            ViewBag.FV = 0;
            return View();
        }
        [HttpPost]
        public IActionResult Index(FutureValueModel model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.FV = model.CalculateFutureValue();
            }
            else
            {
                ViewBag.FV = 0;
            }
            
            return View(model);
        }
    }
}