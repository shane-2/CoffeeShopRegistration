using CoffeeShopRegistration.Models;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;

namespace CoffeeShopRegistration.Controllers
{
   
    public class HomeController : Controller
    {
        UserList Use = new UserList();
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Result(User c)
        {
            Use.AddNew(c);

            return View(c);
        }
        public IActionResult Form()
        {
            return View();
        }
        public IActionResult Index()
        {
            return View();
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