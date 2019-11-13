using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace frontend.controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        public IActionResult Index()
        {
            return File("index.html", "text/html");
        }

        [HttpGet("/doubling")]
        public IActionResult Index(int? input)
        {
            var doubled = input * 2;
            if (input == null)
            {
                return Json(new { error = "Please provide an input!" });
            }
            else
            {
                return Json(new { received = input, result = doubled });
            }
        }

        [HttpGet("/greeter")]
        public IActionResult Index([FromQuery]string name, string title)
        {
            if (name == null && title == null)
            {
                return Json(new { error = "Please provide a name and a title!", status = 400 });
            }
            else if (title == null)
            {
                return Json(new { error = "Please provide a title!", status = 400 });
            }
            else if (name == null)
            {
                return BadRequest(new { error = "Please provide a name!", status = 400 });
            }
            else
            {
                return Json(new { welcome_message = "Oh, hi there " + name + ", my dear " + title + "!" });
            }
        }

        [HttpGet("/appenda/{appendable}")]
        public IActionResult Index(string appendable)
        {
            /*   if (appendable == null || appendable == "")
               {
                   return Json(new { status = 404 });
               }
               else
               {

               }*/
            return Json(new { appended = appendable + "a" });
        }

        /*      [HttpGet("/appenda/")]
        public IActionResult Append(string appendable)
        {
                return Json(new { status = 404 });
        }*/

        [HttpPost("/dountil/{operation}")]
        public IActionResult Index([FromBody]JObject until, [FromRoute] string operation)
        {
            int result = 0;
            if (operation == "sum")
            {
                for (int i = 1; i <= until.Value<int>("until"); i++)
                {
                    result += i;
                }
            }
         
            else if (operation == "factor")
            {   result = 1;
                for (int i = 1; i <= until.Value<int>("until"); i++)
                {
                    result *= i;
                }
                return Json(new { result = result, status =200 });
            }
            else if (operation == null)
            {
                return Json(new { error  = "Please provide a number!"});
            }
            return Json(new {result = result});
        }
    }
}

