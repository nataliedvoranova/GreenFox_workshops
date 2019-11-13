using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using coloringexercise.Models;
using Microsoft.AspNetCore.Mvc;

namespace coloringexercise.Controllers
{
    [Route ("useful")]
    public class HomeController : Controller
    {
        private UtilityService utilities;
        public HomeController(UtilityService utilities)
        {
            this.utilities = utilities;
        }
        [Route("")]
        public IActionResult Useful()
        {
            return View();
        }
        [Route("colored")]
        public IActionResult GetRandomColor()
        {
            return View("RandomBackground",utilities.RandomColor());
        }
        [Route("email")]
        public IActionResult ValidateEmail(string email)
        {
            return View("ValidateEmail",utilities.ValidateEmail(email));
        }
        [Route ("codeCeasar")]
        public IActionResult CodeCeasar()
        {
            string message = "";
            int number = 0;
            return View(utilities.CodeCeasar(message,number));
        }
        [Route("decodeCeasar")]
        public IActionResult DecodeCeasar()
        {
            string message = "";
            int number = 0;
            return View(utilities.DecodeCeasar(message, number));
        }
        //[Route(@"/email?email=is@this.valid")]
        //public IActionResult ExampleEmail()
        //{
        //    return View(@"/email?email=is@this.valid", "email@host.com");
        //}
    }
}