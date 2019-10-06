using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number from the standard input, then draws a
            // square like this:
            //
            //
            // %%%%%%
            // %    %
            // %    %
            // %    %
            // %    %
            // %%%%%%
            //
            // The square should have as many lines as the number was


            Console.WriteLine("enter a number:");
            int rows = int.Parse(Console.ReadLine());
            
            
            for (int i = 0; i < rows; i++)
                Console.Write("%");                                                 //watch out for brackets!!!
                Console.Write("\n");

            for (int m = 0; m < rows - 2; m++)
            {
                Console.Write("%");
                for (int j = 0; j < rows - 2; j++) Console.Write(" ");
                Console.Write("%");
                Console.Write("\n");
            }


             for (int n = 0; n < rows; n++)
                Console.Write("%");
                Console.Write("\n");
            
        }
    }
}