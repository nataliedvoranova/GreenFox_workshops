using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using loginPage.Models;
using Microsoft.AspNetCore.Mvc;

namespace loginPage.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        private IFox foxService;
        private Fox fox;
        public HomeController(IFox foxService)
        {
            this.foxService = foxService;
        }
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("login")]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [Route("login")]
        public IActionResult Login(string name)
        {
            foreach (var item in foxService.ListOfFoxes)
            {
                if (name != null && item.Name == name)
                {
                    return RedirectToAction("Information", new { name = name });
                }
            }
            fox = new Fox(name);
            foxService.AddFox(fox);
            foxService.SetCurrentFox(name);
            return RedirectToAction("Information", "Home", new { name = name });
        }

        [Route("Information")]
        public IActionResult Information(string name)
        {
             return View(foxService.GetCurrentFox());           
        }

        [Route("TrickCenter")]
        public IActionResult LearnTricks()
        {
            return View();
        }
        [HttpPost("TrickCenter")]
        public IActionResult LearnTricks(string trick)
        {
            fox = foxService.GetCurrentFox();
            fox.listOfTricks.Add(trick);
            return RedirectToAction("TrickCenter");
        }


    }
}