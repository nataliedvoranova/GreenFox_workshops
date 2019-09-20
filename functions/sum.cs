using System;

namespace Doubling
{
    class Program
    { // Write a function called `sum` that returns the sum of numbers from zero to the given parameter
      static int Sum (int [] sumArray)
        {
            int whatever = 0;
            for (int i = 0; i < sumArray.Length; i++)
            {
                whatever += sumArray[i];
            }

            return whatever;
        }

        static void Main(string[] args)
        {
            
            int[] array = new int[4];
            array[0] = 5;
            array[3] = 5;
            Console.WriteLine(Sum(array));


    }
}