using System;
using System.Collections.Generic;
using System.Text;

namespace garden_exercise
{
    /*The task is to create a garden application, so in your main method you should create a garden with flowers and trees.
         * The program should demonstrate an example garden with two flowers (yellow and blue) and two trees (purple and orange). 
         * In the example after creating them you should show the user, how the garden looks like.
         * After that the program should water the garden twice, first with the amount of 40 then with 70. 
         * And after every watering the user should see the state of the garden as you can see in the output.
        the Garden
        is able to hold unlimited amount of flowers or trees
        when watering it should only water those what needs water with equally divided amount amongst them
        eg. watering with 40 and 4 of them need water then each gets watered with 10
        The Flower
        needs water if its current water amount is less then 5
        when watering it the flower can only absorb the 75% of the water
        eg. watering with 10 the flower's amount of water should only increase with 7.5
        The Tree
        needs water if its current water amount is less then 10
        when watering it the tree can only absorb the 40% of the water
        eg. watering with 10 the tree's amount of water should only increase with 4*/
    class FlowerClass
    {
        public string Colour { get; set; }
        public double WaterPlantHas { get; set; } = 0;
        //public bool IsWaterNeeded { get; set; } = true;

        public FlowerClass (string colour = "blue")
        {
            Colour = colour;
        }
    }
    class TreeClass : FlowerClass
    {
        public TreeClass(string colour)
        {
        }
    }
    class GardenClass
    {
        double noMoreWater = 0;
        List<FlowerClass> ListOfFlowers { get; set; }
        List<TreeClass> ListOfTrees { get; set; }
        public double amountOfPlants =0;

        public GardenClass()
        {
            ListOfFlowers = new List<FlowerClass>();
            ListOfTrees = new List<TreeClass>();
        }
        public void AddFlower(FlowerClass flower)
        {
            ListOfFlowers.Add(flower);
            amountOfPlants++;
        }

        public void AddTree(TreeClass tree)
        {
            ListOfTrees.Add(tree);
            amountOfPlants++;
        }

        public bool IsWaterNeeded()
        {
            double noMoreWater = 0;
            foreach (var flower in ListOfFlowers)
            {
                if (flower.WaterPlantHas < 5)
                {
                    Console.WriteLine($"The {flower.Colour} flower needs water.");
                }
                else
                {
                    Console.WriteLine($"The {flower.Colour} flower doesn't need water.");
                    noMoreWater++;
                }
            }
            foreach (var tree in ListOfTrees)
            {
                if (tree.WaterPlantHas < 10)
                {
                    Console.WriteLine($"The {tree.Colour} tree needs water.");
                }
                else
                {
                    Console.WriteLine($"The {tree.Colour} tree doesn't need water.");
                    noMoreWater++;
                }
            }
            return true;
        }

        public void ToWater(double wateringAmount)
        {
            /*double noMoreWater = 0;
            foreach (var flower in ListOfFlowers)
            {
                if (flower.WaterPlantHas >5)
                {
                    noMoreWater++; 
                }
            }
            foreach (var tree in ListOfTrees)
            {
                if (tree.WaterPlantHas > 5)
                {
                    noMoreWater++;
                }
            }*/

            double amountNeedsWater = amountOfPlants - noMoreWater;
            foreach (var flower in ListOfFlowers)
            {
                flower.WaterPlantHas += (wateringAmount / amountNeedsWater) * 0.75;
            }
            foreach (var tree in ListOfTrees)
            {
                tree.WaterPlantHas += (wateringAmount / amountNeedsWater) * 0.4;
            }
            IsWaterNeeded();
        }



    }
}
