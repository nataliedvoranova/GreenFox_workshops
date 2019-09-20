using System;

namespace Third
{
    class Program
    {
        static void Main(string[] args)
        { 
            // - Create (dynamically) a two dimensional array
            //   with the following matrix. Use a loop!
            //
            //   1 0 0 0
            //   0 1 0 0
            //   0 0 1 0
            //   0 0 0 1
            //
            // - Print this two dimensional array to the output
       
         int[,] array = new int[4, 4]
            {
                { 1, 0, 0, 0},
                { 0, 1, 0, 0},
                { 0, 0, 0, 0},
                { 0, 0, 0, 1}
            };

            {
                for (int m = 0; m < array.GetLength(0); m++)
                {

                    for (int k = 0; k < array.GetLength(1); k++)
                    {
                        Console.Write(array[m, k]);
                    }

                    Console.WriteLine();
                }
                Console.WriteLine();

            


        }
    }
}