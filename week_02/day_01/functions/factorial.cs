using System;

namespace Doubling
{
    class Program
    {
         // - Create a function called `Factorio`
            //   that returns it's input's factorial

       static int Factorio (int factorial)
        {
            int i, number;
            Console.WriteLine("Enter the Number");
            number = int.Parse(Console.ReadLine());
            factorial = number;
            for (i = number - 1; i >= 1; i--)
            {
                factorial = factorial * i;
            }
            return factorial;
        }

        static void Main(string[] args)
        {
            int input = 5;

            Console.WriteLine(Factorio(input));
            Console.ReadLine();


    }
}