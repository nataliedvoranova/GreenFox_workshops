using System;

namespace treeswithclasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree treeOne = new Tree("chestnut ", "brown ", 15, " male");
            Tree treeTwo = new Tree("oak ", "brown", 21, " male");
            Tree treeThree = new Tree("chestnut ", "brown ", 15, " female");
            Tree treeFour = new Tree("chestnut ", "black ", 15, " male");
            Tree treeFive = new Tree("mapple ", "brown ", 15, " female");

            Console.WriteLine(treeOne.Type + treeOne.Colour+ treeOne.Age+ treeOne.Sex);
            Console.WriteLine(treeTwo.Type + treeTwo.Colour + treeTwo.Age + treeTwo.Sex);
            Console.WriteLine(treeThree.Type + treeThree.Colour + treeThree.Age + treeThree.Sex);
            Console.WriteLine(treeFour.Type + treeFour.Colour + treeFour.Age + treeFour.Sex);
            Console.WriteLine(treeFive.Type + treeFive.Colour + treeFive.Age + treeFive.Sex);
        }
    }
}
