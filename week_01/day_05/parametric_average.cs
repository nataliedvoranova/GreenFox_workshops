
using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for a number.
            // It would ask this many times to enter an integer,
            // if all the integers are entered, it should print the sum and average of these
            // integers like:
            //
            // Sum: 22, Average: 4.4

            Console.WriteLine("Please enter a number");
            int userNumber1 = int.Parse(Console.ReadLine());
            Console.WriteLine("please enter another number");
            int userNumber2 = int.Parse(Console.ReadLine());
            Console.WriteLine("please enter another number");
            int userNumber3 = int.Parse(Console.ReadLine());

            int sum = userNumber1 + userNumber2 + userNumber3;
            double average = sum / 3;

            Console.WriteLine("sum: " + sum + " average: " + average);
        }
    }
}