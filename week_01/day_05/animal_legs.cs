using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for two integers
            // The first represents the number of chickens the farmer has
            // The second represents the number of pigs owned by the farmer
            // It should print how many legs all the animals have

            Console.WriteLine("enter number of chickens: ");
            int chickens = int.Parse(Console.ReadLine());
            Console.WriteLine("enter number of pigs: ");
            int pigs = int.Parse(Console.ReadLine());

            Console.WriteLine("chicken legs: " + (chickens*2) + " pig legs: " + (pigs*4) + " of total: " + ((chickens * 2)+(pigs * 4)) + " legs");
        }
    }
}