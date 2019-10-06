using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number from the standard input, then draws a
            // diamond like this:
            //
            //
            //    *
            //   ***
            //  *****
            // *******
            //  *****
            //   ***
            //    *
            //
            // The diamond should have as many lines as the number was

            Console.WriteLine("enter a number");
            int row = int.Parse(Console.ReadLine());
            int temp = row;
            int temp2 = row;

            for (int i = 1; i <= row-1; i++)
            {
                for (int j = 1; j < temp; j++)
                {
                    Console.Write(" ");
                }
                temp--;

                for (int j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");

                }

                Console.Write("\n");

            }


            for (int k = 1; k <= row; k++)
            {

                for (int j = 1; j <= 2 * temp2 - 1; j++)
                {
                    Console.Write("*");
                }

                Console.Write("\n");

                for (int l = 1; l <= k; l++)
                {
                    Console.Write(" ");
                }
                temp2--;

            }
        }
        }
    }
