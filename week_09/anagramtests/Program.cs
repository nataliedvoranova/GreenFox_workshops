using System;
using System.Collections.Generic;

namespace anagramtests
{
    public class Program
    {
        static void Main(string[] args)
        {
            var input = new List<string> {
                "racecar",
            "arcecar" };
     
            CheckAnagram(input);
        }

        public static bool CheckAnagram(List<string> input)
        {
            var inputOne = input[0].ToLower().ToCharArray();
            var inputTwo = input[1].ToLower().ToCharArray();

            Array.Sort(inputOne);
            Array.Sort(inputTwo);

            for (int i = 0; i < inputOne.Length; i++)
            {
                if (inputOne[i] != inputTwo[i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
