using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TempData.Models;

namespace TempData.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            TempData["myName"] = "Gujjula Pradeep Reddy";
            TempData["myAge"] = 22;
            return View();
        }

        public IActionResult Privacy()
        {
            int? showMyAge = (int?)TempData["myAge"];
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}