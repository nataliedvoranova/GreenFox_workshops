using System;
using System.IO;
using System.Linq;

namespace ConsoleApp_week_3​
{
    class Program
    {
        // Write a function that takes a filename as string,
        // then returns the number of lines the file contains.
        // It should return zero if it can't open the file, and
        // should not raise any error.

        static void Main(string[] args)
        {
            TryWrite("./new_file", "hello world!");
        }
        private static void TryWrite(string path, string content)
        {
            try
            {
                File.WriteAllText(path, content);
                File.AppendAllText(path, "\noijrf\n ");

                string[] lines = File.ReadAllLines(path);

                string[] lines = File.ReadAllLines(path);
                Console.WriteLine(lines.Length);

                // int count = File.ReadLines(path).Count();     >>>> MUST use System.Linq;
                // Console.WriteLine(count);


            }
            catch (FileNotFoundException e)
            {
                Console.Error.WriteLine(e);
                Console.WriteLine("0");
            }

        }
    }
}