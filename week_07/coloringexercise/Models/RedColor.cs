using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace coloringexercise.Models
{
    public class RedColor : IColor
    {
        public void PrintColor()
        {
            Console.WriteLine("It is red in color...");
        }
    }
}
