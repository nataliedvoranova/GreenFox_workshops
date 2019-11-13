using System;
using System.Collections.Generic;

namespace ConsoleApp3
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
    class Garden
    {
        public List<Flower> ListOfFlowers { get; set; }
        public List<Tree> ListOfTrees { get; set; }
        public double WaterPlantHas { get; set; } = 0;
        public double WaterPlantNeeds { get; set; }

        public Garden()
        {

        }
        public void AddFlower(Flower flower)
        {
            ListOfFlowers.Add(flower);
        }

        public void AddTree(Tree tree)
        {
            ListOfTrees.Add(tree);
        }

        public void ToWater()
        {
            double amountOfPlants = ListOfFlowers.Count + ListOfTrees.Count;
            double watering;

        }

    }
    
    class Flower : Garden
    {
        public Flower(string colour)
        {

        }
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

    class Tree :Garden
    {
        public Tree(string colour)
        {

        }

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
            Flower flowerOne = new Flower("yellow");
            Flower flowerTwo = new Flower("blue");
            flowerOne.AddFlower();
            flowerTwo.AddFlower();

            Tree treeOne = new Tree("purple");
            Tree treeTwo = new Tree("orange");
            treeOne.AddTree();
            treeTwo.AddTree();
            Console.WriteLine(Garden);
        

        }
        
    }
}
