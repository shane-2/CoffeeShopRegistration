using CoffeeShopRegistration.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;

namespace CoffeeShopRegistration.Controllers
{
    public class ProductController : Controller
    {
        private CoffeeDbContext _coffeeDbContext = new CoffeeDbContext();


        public IActionResult Index()
        {
            List<Item> result = _coffeeDbContext.Items.ToList();

            return View(result);
        }

        public IActionResult DetailC(int id)
        {
            Item p = _coffeeDbContext.Items.FirstOrDefault(x => x.Id == id);
            //option 1
            //make new model that contains all you want to bring down takes in post and comments and put them all together in model
            //options 2
            //send it through viewdata
            

            return View(p);
        }
        public IActionResult Item(int id)
        {
            Item p = _coffeeDbContext.Items.FirstOrDefault(x => x.Id == id);

            return View(p);
        }
    }
}
