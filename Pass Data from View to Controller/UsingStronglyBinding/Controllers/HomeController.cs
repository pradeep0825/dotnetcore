using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using UsingStronglyBinding.Models;

namespace UsingStronglyBinding.Controllers
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
            return View();
        }

        [HttpPost]
        public string PostUsingStronglyBinding(Employee emp)
        {
            string name = emp.Name;
            int sal = emp.Salary;
            return "Details are : " + name + ", salary is: " + sal;
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