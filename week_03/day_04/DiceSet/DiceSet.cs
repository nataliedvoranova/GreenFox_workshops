using System;

namespace GreenFoxAcademy
{
    public class DiceSet
    {
        public Random randomValue = new Random();
        public int[] dice = new int[6];

        public int[] Roll()
        {
            foreach (var dic in dice)
            {
                for (int i = 0; i < dice.Length; i++)
                {
                      dice[i] = randomValue.Next(1, 7);
                }
            } 
            return dice;
        }
        

        public int[] GetCurrent()
        {
            foreach (var dic in dice)
            {
                Console.WriteLine(dic);
            }
            return dice;
        }

        public int GetCurrent(int i)
        {
            return dice[i];
        }
        public void Reroll()
        {                                                      
            for (int i = 0; i < dice.Length; i++)
            {
                while (dice[i] !=6)
                {
                    dice[i] = randomValue.Next(1, 7);
                }
            }
        }
        public void Reroll(int k)
        {
            while (dice[k] != 6)                                            
            {
             dice[k] = randomValue.Next(1, 7);
            } 
        }
    }
}