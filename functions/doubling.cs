using System;

namespace Doubling
{
    class Program
    {
        static int Doubling(int DoubleInput)
        {
            // - Create an integer variable named `baseNum` and assign the value `123` to it
            // - Create a function called `Doubling` that doubles it's input parameter and returns with an integer
            // - Print the result of `Doubling(baseNum)`
            
            DoubleInput = DoubleInput * 2;
            return DoubleInput;
        }


        static void Main(string[] args)
        {
            int baseNum = 123;
            
            Console.WriteLine(Doubling(baseNum));
            
           
        }
    }
}