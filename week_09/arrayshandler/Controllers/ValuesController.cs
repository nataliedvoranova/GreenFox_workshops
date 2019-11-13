using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace arrayshandler.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : Controller
    {
        // GET api/values
        [HttpGet("/arrays")]
        public ActionResult Get(JObject jsonObj)
        {

           int[] numbers = jsonObj.Value<int[]>("numbers");
           int result = 0;

            if (jsonObj.Value<string>("what") == "sum")
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    result += numbers[i];
                }
            }
            else if (jsonObj.Value<string>("what") == "double")
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    result = numbers[i] * 2;
                }
            }
            else if (jsonObj.Value<string>("what") == "multiply")
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    result = numbers[i] * numbers[i];
                }
            }
            return Json(new { Result = result });
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
