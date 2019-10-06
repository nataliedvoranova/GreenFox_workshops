
using System;
using System.Collections.Generic;

namespace TakesLonger
{
    public class TakesLonger
    {

                /*We are going to represent a shopping list in a list containing strings.
                Create a list with the following items.
                Eggs, milk, fish, apples, bread and chicken
                Create an application which solves the following problems.
                Do we have milk on the list?
                Do we have bananas on the list?*/
        public static void Main(string[] args)
        {
            List<string> shoppingList = new List<string> { "eggs", "milk", "fish", "apples", " bread", "chicken" };

            if (shoppingList.Contains("milk"))
            {
                Console.WriteLine("There's milk on the shopping list.");
            }
            else
            {
                Console.WriteLine("There's no milk on the shopping list.");
            }
            if (shoppingList.Contains("bananas"))
            {
                
              Console.WriteLine("There's bananas on the shopping list.");
            }
            else
            {
               Console.WriteLine("There's no bananas on the shopping list.");
            }
            
        }
        
    }
}