using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace loginPage.Models
{
    public class Fox
    {
        public string Name { get; set; }
        public List<string> listOfTricks = new List<string>();
        public string Food { get; set; }
        public string Drink { get; set; }

        public Fox(string name)
        {
            Name = name;
        }
    }
}
