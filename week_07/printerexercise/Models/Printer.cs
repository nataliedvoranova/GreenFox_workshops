using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace printerexercise.Models
{
    public class Printer
    {
        public void Log(string message)
        {
            Console.WriteLine(" --- " + DateTime.Now + " MY PRINTER SAYS --- " + message);
        }
    }
}
