using System;

namespace piratesworkshop
{
    class Program
    {
        static void Main(string[] args)
        {
            Pirate Joe = new Pirate("Joe");
            Pirate John = new Pirate("John");
            Pirate Mel = new Pirate("Mel");
            Pirate Marc = new Pirate("Marc");
            Pirate Joseph = new Pirate("Joseph");
            Pirate Joe2 = new Pirate("Joe2");
            Pirate John2 = new Pirate("John2");
            Pirate Mel2 = new Pirate("Mel2");
            Pirate Marc2 = new Pirate("Marc2");
            Pirate Joseph2 = new Pirate("Joseph2");
            Pirate Joe3 = new Pirate("Joe3");
            Pirate John3 = new Pirate("John3");
            Pirate Mel3 = new Pirate("Mel3");
            Pirate Marc3 = new Pirate("Marc3");
            Pirate Joseph3 = new Pirate("Joseph3");

            Ship shipOne = new Ship("ShipOne");
            shipOne.FillShip(Joe);
            shipOne.FillShip(John);
            shipOne.FillShip(Marc);
            shipOne.FillShip(Joe2);
            shipOne.FillShip(John2);
            shipOne.FillShip(Marc2);
            shipOne.FillShip(Joe3);
            shipOne.FillShip(John3);
            shipOne.FillShip(Marc3);

            Ship shipTwo = new Ship("ShipTwo");
            shipTwo.FillShip(Mel);
            shipTwo.FillShip(Joseph);
            shipTwo.FillShip(Mel2);
            shipTwo.FillShip(Joseph2);
            shipTwo.FillShip(Mel3);
            shipTwo.FillShip(Joseph3);

            Joseph.DrinkSomeRum();
            Joe.DrinkSomeRum();
            Joe.DrinkSomeRum();
            Joe.HowIsItGoindMate();
            Joe.DrinkSomeRum();
            Joe.DrinkSomeRum();
            Joe.DrinkSomeRum();
            Joe.DrinkSomeRum();
            // Joe.HowIsItGoindMate();
            Joe.Die();
            Joe.HowIsItGoindMate();
            Joe.DrinkSomeRum();
            Mel.DrinkSomeRum();
            Mel.DrinkSomeRum();
            Mel.DrinkSomeRum();
            Mel.DrinkSomeRum();
            John.Brawl(Mel);
            John.DrinkSomeRum();
            shipOne.ShiptStatus();
            shipTwo.ShiptStatus();
            Console.WriteLine();
            shipOne.Battle(shipTwo);
            Console.WriteLine();
            shipOne.ShiptStatus();
            Console.WriteLine();
            shipTwo.ShiptStatus();
        }
    }
}
