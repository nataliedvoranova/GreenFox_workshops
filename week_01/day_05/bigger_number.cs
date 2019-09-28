using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for two numbers and prints the bigger one

            Console.WriteLine("enter a number");
            int numOne = int.Parse(Console.ReadLine());

            Console.WriteLine("enter a second number");
            int numTwo = int.Parse(Console.ReadLine());

            if (numOne>numTwo)
            {
                Console.WriteLine(numOne + " is bigger");
            }
            else { Console.WriteLine(numTwo + " is bigger"); }
        }
    }
}