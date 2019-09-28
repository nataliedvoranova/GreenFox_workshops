using System;

namespace GreenFox
{
    class Program
    {
        static void Main()
        {
            // Write a program that reads a number from the standard input, then draws a
            // pyramid like this:
            //
            //
            //    *
            //   ***
            //  *****
            // *******
            //
            // The pyramid should have as many lines as the number was

            Console.WriteLine("enter a number");
            int rows = Int32.Parse(Console.ReadLine());
            int temp = rows;

            Console.Write("\n");

            for (int i = 1; i <= rows; i++)
            {
                 for (int j = 1; j < temp; j++)         //spaces first!!!
                    Console.Write(" ");

                temp--;
               

                for (int j = 1; j <= 2 * i - 1; j++)   //stars           2*rows -1 >>> number of characters per line (w/ spaces)
                    Console.Write("*");                // WRITE!!! not writeline + create new line in loop!!!
                 Console.Write("\n");

            }
        }
    }
}

