using System;

namespace Third
{
    class Program
    {
        static void Main(string[] args)
        { 
            // - Create an array variable named `animals`
            //   with the following content: `["koal", "pand", "zebr"]`
            // - Add all elements an `"a"` at the end

                    string[] animals = { "koal", "pand", "zebr" };
                    
                    foreach (var item in animals)
                    {
                        Console.WriteLine(item +"a");
                    }
                    Console.WriteLine();
        }
    }
}