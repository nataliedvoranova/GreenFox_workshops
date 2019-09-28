using System;

namespace Third
{
    class Program
    {
        static void Main(string[] args)
        { 
           // - Create an array variable named `numList`
            //   with the following content: `[3, 4, 5, 6, 7]`
            // - Double all the values in the array
       
        

                    int[] numList = { 3, 4, 5, 6, 7 };
                    for (int g = 0; g < numList.Length; g++)
                    {
                        numList[g] *= 2;
                    }

                    foreach (var item in numList)
                    {
                        Console.WriteLine(item);
                    }
                }
                Console.WriteLine();


            


        }
    }
}