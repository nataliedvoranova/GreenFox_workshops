using System;

namespace Doubling
{
    class Program
    {
        
        static string AppendAFunc(string AppA)

        {
           
           AppA = AppA + "a";
            return AppA;
        }


        static void Main(string[] args)
        {
            string typo = "Chinchill";
            Console.WriteLine(AppendAFunc(typo));
           
        }
    }
}