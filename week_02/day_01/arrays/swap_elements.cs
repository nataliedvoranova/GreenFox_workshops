using System;

namespace Third
{
    class Program
    {
        static void Main(string[] args)
        { 
               // - Create an array variable named `abc`
            //   with the following content: `["first", "second", "third"]`
            // - Swap the first and the third element of `abc`

                    string[] abc = { "first ", "second ", "third " };
            string first = abc[0];
            abc[abc.Length - 1] = first;
            Console.WriteLine(abc[abc.Length - 1] + abc[1] + first);
            Console.WriteLine();

        }
    }
}