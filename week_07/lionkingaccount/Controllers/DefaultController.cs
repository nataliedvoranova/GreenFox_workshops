using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using lionkingaccount.Models;

namespace lionkingaccount.Controllers
{
    public class DefaultController : Controller
    {
        List<BankAccount> simbaAccount = new List<BankAccount>()
        {
        new BankAccount("Simba", 2000, "Lion", true),
        new BankAccount("Barbra",345, "Zebra"),
        new BankAccount ("Elvis", 9733.24, "Panther"),
        new BankAccount ("Mostafa", 423.8, "Lion")
        };
        public IActionResult Index()
        {
            return View();
        }
        [Route("Show")]
        public IActionResult Show()
        {
            return View(simbaAccount);
        }

        [Route("Message")]
        public ActionResult Message()
        {
            ViewBag.Message = "This is an <em>HTML</em> text. <b>Enjoy yourself!</b>";
            return View();
        }

        [Route("AllAcounts")]
        public IActionResult AllAccounts()
        {
            return View(simbaAccount);
        }
    }
}