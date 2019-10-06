using System;
using System.Collections.Generic;

namespace sum
{
    public class SumOperations
    {
        
        public int Sum(List<int> numsToSum)
        {
            int resultSum =0;
            if (numsToSum != null)
            {
                for (int i =0; i < numsToSum.Count; i++)
                {
                 resultSum += numsToSum[i];
                }
            }
         return resultSum;
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listOfNumbers = InitializeInt();
            SumOperations result = new SumOperations();
            Console.WriteLine(result.Sum(listOfNumbers));
        }

          public static List<int> InitializeInt()
        { 
            List<int> listOfNumbers = new List<int>();
            listOfNumbers.Add(2);
            listOfNumbers.Add(2);
            listOfNumbers.Add(0);
            listOfNumbers.Add(4);
           return listOfNumbers;
            
        }
    }
}
