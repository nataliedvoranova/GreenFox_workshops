using System;

namespace Sharpie
{
            /*Create Sharpie class
        We should know about each sharpie their Color(which should be a string), Width(which will be a floating point number), InkAmount(another floating point number)
        When creating one, we need to specify the Color and the Width
        Every sharpie is created with a default 100 as InkAmount
        We can Use() the sharpie objects
        which decreases inkAmount*/
    class Program
    {
        static void Main(string[] args)
        {
            double defaultInkAmount = 100;

            Class_sharpie sharpieOne = new Class_sharpie();
            Class_sharpie sharpieTwo = new Class_sharpie();
            Class_sharpie sharpieThree = new Class_sharpie();

            sharpieOne.Colour = "blue";
            sharpieOne.Width = 10.5;
            sharpieOne.InkAmount = defaultInkAmount;

            sharpieTwo.Colour = "yellow";
            sharpieTwo.Width = 14.5;
            sharpieTwo.InkAmount = defaultInkAmount;

            sharpieThree.Colour = "red";
            sharpieThree.Width = 6.5;
            sharpieThree.InkAmount = defaultInkAmount;

            sharpieOne.UsingSharpie();
            sharpieTwo.UsingSharpie();
            sharpieThree.UsingSharpie();
            sharpieThree.UsingSharpie();


            Console.WriteLine(sharpieOne.Colour + " " + sharpieOne.Width + " " + sharpieOne.InkAmount);
            Console.WriteLine(sharpieTwo.Colour + " " + sharpieTwo.Width + " " + sharpieTwo.InkAmount);
            Console.WriteLine(sharpieThree.Colour + " " + sharpieThree.Width + " " + sharpieThree.InkAmount);
        }
    }
}
