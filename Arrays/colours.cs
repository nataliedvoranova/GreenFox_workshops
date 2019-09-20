using System;

namespace Third
{
    class Program
    {
        static void Main(string[] args)
        { 
                // - Create a two dimensional array
            //   which can contain the different shades of specified colors
            // - In `colors[0]` store the shades of green:
            //   `"lime", "forest green", "olive", "pale green", "spring green"`
            // - In `colors[1]` store the shades of red:
            //   `"orange red", "red", "tomato"`
            // - In `colors[2]` store the shades of pink:
            //   `"orchid", "violet", "pink", "hot pink"`
       
        
                string[][] shades =
                {
                    new string [] { "lime, forest green, olive, pale green, spring green" },
                    new string [] { "orange red ", "red ", "tomato " },
                    new string [] { "orchid ", "violet ", "pink ", "hot pink " }
                };
                { for (int n = 0; n < shades.Length; n++)
                    {


                        for (int k = 0; k < shades[n].Length; k++)
                        {

                            System.Console.Write(shades[n][k]);
                        }
                        System.Console.WriteLine();
                    }


            


        }
    }
}