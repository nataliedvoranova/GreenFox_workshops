using System;
using System.Collections.Generic;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringOne = "hello";
            string stringtwo = "olhle";

        }

        public bool Anagram(string string1, string string2)
        {
            if (string1.Length != string2.Length)
            {
                return false;
            }
            if (string1 == string2)
            {
                return true;
            }
            Dictionary<char, int> pool = new Dictionary<char, int>();
            foreach (var item in pool)
            {

            }
        }
    }
}
