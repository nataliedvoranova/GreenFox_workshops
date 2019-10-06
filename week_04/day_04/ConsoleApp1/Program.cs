using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringOne = "hello";
            string stringTwo = "loehl";

        }

        public static bool IsAnagram(string string1, string string2)
        {
            if(string1.Length != string2.Length)
            {
                return false;
            }
            foreach (var character in string1)
            {
                if (CountLetters(string1, 'h') != CountLetters(string2, 'h'))
                {
                    return false;
                }
            else
            {
            return true;
            }

            
        }
        public static int CountLetters(string str, char character)
        {
            int count = 0;
            foreach (var letter in str)
            {
                if (letter == character)
                {
                    count++;
                }
                
            }
            return count;
        }
    }
}
