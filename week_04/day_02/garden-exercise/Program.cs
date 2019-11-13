using System;
using System.Collections.Generic;

namespace garden_exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            GardenClass garden = new GardenClass();
            FlowerClass yellowFlower = new FlowerClass("Yellow");
            FlowerClass blueFlower = new FlowerClass("Blue");
            TreeClass purpleTree = new TreeClass("Purple");
            TreeClass orangeTree = new TreeClass("Orange");
      
            garden.AddFlower(yellowFlower);
            garden.AddFlower(blueFlower);
            garden.AddTree(purpleTree);
            garden.AddTree(orangeTree);
           
            garden.IsWaterNeeded();
            Console.WriteLine("Watering with 40.");
            garden.ToWater(40);
            Console.WriteLine("Watering with 70.");
            garden.ToWater(70);
        }
    }
}
