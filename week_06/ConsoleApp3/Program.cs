using System;
using System.Linq;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers1 = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };
            var oddNums = numbers1.ToList().Where(n => n % 2 != 0);
            var oddNums2 = numbers1.ToList().FindAll(n => n % 2 != 0);
            var average = numbers1.Where(n => n % 2 != 0).Average(n => n);
            var sqrtPositives = numbers1.Where(n=>n>0).Select(n=>n*n);
            foreach (var item in oddNums)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(average);
            foreach (var item in sqrtPositives)
            {
                 Console.WriteLine(item);
            }
            Console.WriteLine();
            int[] numbers2 = new[] { 3, 9, 2, 8, 6, 5 };
            var sqrtBigger = numbers2.Select(n=>n*n).Where(n => n > 20);
            foreach (var item in sqrtBigger)
            {
                Console.WriteLine(item);
            }

            int[] numbers3 = new int[] { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };
            var frequency = numbers3.Select(n=>n).GroupBy(n=>n);
            foreach (var item in frequency)
            {
                Console.WriteLine(item.Key +" " + item.Count());
            }
            Console.WriteLine();

            string sentence = "Expression to find the frequency of characters in a given string.";
            var charFreq = sentence.ToLower().Where(n => n != ' ' && n!= '.').GroupBy(n => n).OrderByDescending(n=>n.Count());
            foreach (var item in charFreq)
            {
                Console.WriteLine(item.Key + " " + item.Count());
            }
            Console.WriteLine();
            string[] cities = { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };
            var startsWith = cities.Where(n => n.StartsWith("A") && n.EndsWith("I"));
            foreach (var item in startsWith)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            string sentence2 = "One of the functionalities in the EDITOR is to filter uppercase words in a string and highlight them.";
            var upperCase = sentence2.Where(n => Char.IsUpper(n)); //  (n, n.ToUpper(),StringComparison.Ordinal));
            foreach (var item in upperCase)
            {
                Console.WriteLine(item);
            }
        }
    }
}
