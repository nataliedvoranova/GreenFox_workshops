using System;

namespace Doubling
{
    class Program
    {
        

        static string Greet(string Hello)

        {
            // - Create a string variable named `al` and assign the value `Green Fox` to it
            // - Create a function called `Greet` that greets it's input parameter
            //     - Greeting is printing e.g. `Greetings dear, Green Fox`
            // - Greet `al`
           
            Hello = "Hello everyone," + Hello;
            return Hello;
        }


        static void Main(string[] args)
        {
            string al = "Green Fox";
            Console.WriteLine(Greet(al));

           
        }
    }
}