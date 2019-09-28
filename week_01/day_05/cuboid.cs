
using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that stores 3 sides of a cuboid as variables (doubles)
            // The program should write the surface area and volume of the cuboid like:
            //
            // Surface Area: 600
            // Volume: 1000

            double width = 12.4;
            double lenght = 5.9;
            double height = 3.42;

            double surfaceArea = 2 * ((width *lenght) + (height*lenght) + (width* height)) ;
            double volume = width*lenght*height;
            Console.WriteLine(surfaceArea +" " + volume);
        }
    }
}