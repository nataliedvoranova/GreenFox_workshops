using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using webshopapp.Models;

namespace webshopapp.Controllers
{
    public class HomeController : Controller
    {
        List<Product> allProducts = new List<Product>()
        {
            new Product("Running shoes","Nike running shoes for everyday sport.", 1000,5),
            new Product("Printer","Some HP printer that will print pages.",3000,2),
            new Product("Coca Cola","0.5l standard coke.",25,0),
            new Product("Wokin","Chicken with fried rice and WOKIN sauce.",119,100),
            new Product("T-shirt","Blue with a corgi on a bike.",300,1),
        };
        public IActionResult Index()
        {
            return View(allProducts);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

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
