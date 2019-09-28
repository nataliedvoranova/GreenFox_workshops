using System;



namespace ConsoleApp_week_3
{
    class Program
    {// Create a function that takes a number
    // divides ten with it,
    // and prints the result.
    // It should print "fail" if the parameter is 0
    
        public static void Divising(int result, int divisor)
        {
            divisor = int.Parse(Console.ReadLine()); //user input
            result = 10 / divisor;
            // The program doesn't reach this line if the input was 0
            Console.WriteLine(result);
        }
        public static void Main(string[] args)
        {
            Random rand = new Random ();
            
            try  // Prevents the program breaking when attempting dividing by zero
            { 
                Divising(10, rand.Next());
            }
            catch (DivideByZeroException e) //if wanted developper output add:
            {
                                            // Console.Error.WriteLine(e);
                // This line only runs if the input was 0
                Console.WriteLine("Can't divide by zero!");
            }
            catch (Exception e)
            {
                // This line only runs if uncatched exception generated
                Console.WriteLine("uuups, some serious thing happened!");
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
