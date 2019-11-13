using System;
using System.Collections.Generic;

namespace GreenFoxAcademy
{
    class Program
    {
        public static void Main(string[] argv)
        {
            // You have a `DiceSet` class which has a list for 6 dice
            // You can roll all of them with roll()
            // Check the current rolled numbers with getCurrent()
            // You can reroll with reroll()
            // Your task is to roll the dice until all of the dice are 6
            DiceSet diceSet = new DiceSet();

            /*diceSet.GetCurrent();
            diceSet.Roll();
            Console.WriteLine("\n");
            diceSet.GetCurrent();
            Console.WriteLine("\n");
            Console.WriteLine(diceSet.GetCurrent(5)); ;
            Console.WriteLine("\n");*/

            diceSet.Reroll();
            diceSet.GetCurrent();
            /*Console.WriteLine("\n");


            diceSet.Reroll(0);
            diceSet.GetCurrent();
            Console.WriteLine("\n");
            diceSet.Reroll(1);
            diceSet.GetCurrent();
            Console.WriteLine("\n");
            diceSet.Reroll(2);
            diceSet.GetCurrent();
            Console.WriteLine("\n");
            diceSet.Reroll(3);
            diceSet.GetCurrent();*/
        }
    }
}