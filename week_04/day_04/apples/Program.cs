using System;

namespace ConsoleApp3
{
    public class Apples
    {
        public string GetApple()
        {
            return "apple";
        }

    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Apples apple = new Apples();
            Console.WriteLine(apple.GetApple());
        }

    }
}