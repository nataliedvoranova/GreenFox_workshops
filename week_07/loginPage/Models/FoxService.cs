using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace loginPage.Models
{
    public class FoxService: IFox
    {
        public List<Fox> ListOfFoxes { get; set; } = new List<Fox>();
        public Fox CurrentFox { get; set; }

        public FoxService()
        {
            ListOfFoxes = new List<Fox>();
        }
        public List<Fox> AddFox(Fox fox)
        {
            ListOfFoxes.Add(fox);
            return ListOfFoxes;
        }

        public Fox FindFoxByName(string name)
        {
            CurrentFox= ListOfFoxes.Find(f => f.Name == name);
            return CurrentFox;
        }
        public Fox SetCurrentFox(string name)
        {
            CurrentFox = ListOfFoxes.First(fox => name == fox.Name);
            return CurrentFox;
        }
        public Fox GetCurrentFox()
        {
            return CurrentFox;
        }
    }
}
