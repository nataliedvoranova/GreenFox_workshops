using System;
using System.IO;

namespace ConsoleApp_week_3​
{
    class Program
    {
        // Write a program that opens a file called "my-file.txt", then prints
        // each line from the file.
        // If the program is unable to read the file (for example it does not exist),
        // then it should print the following error message: "Unable to read file: my-file.txt"

        static void Main(string[] args)
        {
            try
            {

                TryWrite("./my-file", "hello world!");

                /*if (!File.Exists("./my-file.txt"))                >>>> another option
                {
                    Console.WriteLine("Unable to find file: my-file.txt");
                }*/
            }
           

            catch (FileNotFoundException e)
            {
                // Let the user know what went wrong.
                Console.WriteLine("Unable to read file: my-file.txt");
                Console.WriteLine(e.Message);
            }
        }

        static void TryWrite(string path, string content)
        {

            {
                File.WriteAllText(path, content);
                File.AppendAllText(path, "\nHello again\nagain \nagain");

                Console.WriteLine(File.ReadAllText(path));
            }
        }

    }
}