using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
           // int a = 3;
            // make it bigger by 10

           // int b = 100;
            // make it smaller by 7

           // int c = 44;
            // please double c's value

            //int d = 125;
            // please divide by 5 d's value

            //int e = 8;
            // please cube of e's value

            int a = 3;
            a += 10;
            int b = 100;
            b -= 7;

            int c = 44;
            c *= 2;
            int d = 125;
            d /= 5;

            double e = 125;
            double i = 1.0 / 3.0;
            e = Math.Pow(e, i);
            Console.WriteLine(a + " " + b + " " + c + " " + d);
            Console.WriteLine(e);

           // int f1 = 123;
          //  int f2 = 345;
            // tell if f1 is bigger than f2 (print as a boolean)

            //int g1 = 350;
           // int g2 = 200;
            // tell if the double of g2 is bigger than g1 (print as a boolean)
           
            int g1 = 350;
            int g2 = 200;
            g2 *= 2;
            bool compared = false;
            if (g1 > g2)
            {
                compared = false;
                Console.WriteLine(compared);

            }
            else
            {
                compared = true;
                Console.WriteLine(compared);
            }

           // int h = 1357988018575474;
            // tell if 11 is a divisor of h (print as a boolean)

             double h = 1357988018575474.0;
            h %= 11.0;
            bool divisor = true;
            if (h == 0)
            {
                divisor = true;
                Console.WriteLine(divisor);
            }
            else
            {
                divisor = false;
                Console.WriteLine(divisor);

            //New version:

            double h = 1357988018575474.0;
            h %= 11.0;
            bool divisor = h == 0;
            Console.WriteLine(divisor);
         
         
           // int i1 = 10;
           // int i2 = 3;
            // tell if i1 is higher than i2 squared and smaller than i2 cubed (print as a boolean)
            
            int i1 = 10;
            int i2 = 3;
            
            Console.WriteLine(i1 > Math.Pow((double)i2, 3));
          
            //or:
            int i3 = 10;
            int i4 = 3;
            double i5 = 0.0;
            bool comparison = true;
            i5 = (double)Math.Pow(i4, 3);
            if (i5>i3)
            {
                comparison = true;
                Console.WriteLine(comparison);
            }
            else
            {
                comparison = false;
                Console.WriteLine(comparison);
            }



           // int j = 1521;
            // tell if j is divisible by 3 or 5 (print as a boolean)
              
            int j = 1521;
            j %= 5;
            j %= 3;
            bool dividedBy5 = j % 5 == 0;
            bool dividedBy3 = j % 3 == 0;
            Console.WriteLine("Divisable by 3 " + dividedBy3);
            Console.WriteLine("Divisable by 5" + dividedBy5);

           
          




        }
    }
}