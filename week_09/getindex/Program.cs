using System;
using System.Collections.Generic;

namespace getindex
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int elementToFind=1;
            List<int> testList = new List<int> { elementToFind };
            
            Console.WriteLine(GetIndex(elementToFind, testList));
        }

        public static int GetIndex(int value, List<int> list)
        {
            return (list != null && list.Contains(value)) ? list.IndexOf(value) : -1;
        }
    }
}
