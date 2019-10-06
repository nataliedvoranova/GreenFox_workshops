using System;
using System.Collections.Generic;

namespace ConsoleApp3
{

    class Garden
    {
        public List<Flowers> ListOfFlowers { get; set; }
        public List<Trees> ListOfTrees { get; set; }
        public double WaterPlantHas { get; set; } = 0;
        public string Colour { get; set; }
        public double WaterPlantNeeds { get; set; }

        public Garden()
        {

        }
        public void AddFlower(Flowers flower)
        {
            ListOfFlowers.Add(flower);
        }

        public void AddTree(Trees tree)
        {
            ListOfTrees.Add(tree);
        }

        public void ToWater()
        {
            double amountOfPlants = ListOfFlowers.Count + ListOfTrees.Count;
            double watering;

        }

    }
    
    class Flowers : Garden
    {

        public void NeedsWater()
        {
            if (WaterAmount < 5)
            {
                Console.WriteLine("needs water");
            }
            else
            {
                Console.WriteLine("doesn't need water");
            }
        }
    }

    class Trees :Garden
    {

        public void NeedsWater()
        {
            if (WaterAmount < 10)
            {
                Console.WriteLine("needs water");
            }
            else
            {
                Console.WriteLine("doesn't need water");
            }

        }

    }
        class Program
        {
            static void Main(string[] args)
            {
            Flowers flowerOne = new Flowers();
            
            }
        }
    }
}
