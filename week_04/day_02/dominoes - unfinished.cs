using System;
using System.Collections.Generic;

namespace Domino
{
   public class Domino : IComparable <Domino>
    {
            public int CompareTo(Domino dominoes)
            {
            return this.values[0].CompareTo(dominoes.values[0]);
            }


            private readonly int[] values;

            public Domino(int valueA, int valueB)
            {
                this.values = new int[] { valueA, valueB };
            }

            public int[] GetValues()
            {
                return values;
            }

        public class Thing
        {
            private string name;
            private bool completed;

            public Thing(string name)
            {
                this.name = name;
            }

            public void Complete()
            {
                completed = true;
            }
        }
    }
       
    public class Dominoes
    {

        public static void Main(string[] args)
        {
            var dominoes = InitializeDominoes();
            // You have the list of Dominoes
            // Order them into one snake where the adjacent dominoes have the same numbers on their adjacent sides
            // Create a function to write the dominous to the console in the following format
            // eg: [2, 4], [4, 3], [3, 5] ...

            dominoes.Sort();
            foreach (var item in dominoes)
            {
                int[] printValue = new int[2];
                printValue = item.GetValues();
                Console.Write(("[" + printValue[0] + ", " + printValue[1] + "]"));
            }

        }

        public static List<Domino> InitializeDominoes()
        {
            var dominoes = new List<Domino>();
            dominoes.Add(new Domino(5, 2));
            dominoes.Add(new Domino(4, 6));
            dominoes.Add(new Domino(1, 5));
            dominoes.Add(new Domino(6, 7));
            dominoes.Add(new Domino(2, 4));
            dominoes.Add(new Domino(7, 1));
            return dominoes;
        }
    }
}