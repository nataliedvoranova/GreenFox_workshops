using System;

namespace Animal
{
           /* Create an Animal class
        Every animal has a hunger value, which is a whole number
        Every animal has a thirst value, which is a whole number
        when creating a new animal object these values are created with the default 50 value
        Every animal can Eat() which decreases their hunger by one
        Every animal can Drink() which decreases their thirst by one
        Every animal can Play() which increases both by one*/
    class Program
    {
        static void Main(string[] args)
        {
            Class_animal animalOne = new Class_animal();
            Class_animal animalTwo = new Class_animal();
            Class_animal animalThree = new Class_animal();

            int defualtHunger = 50;
            int defaultThirst = 50;

            animalOne.Hunger = defualtHunger;
            animalOne.Thirst = defaultThirst;

            animalTwo.Hunger = defualtHunger;
            animalTwo.Thirst = defaultThirst;

            animalThree.Hunger = defualtHunger;
            animalThree.Thirst = defaultThirst;

            animalOne.Eating();
            animalTwo.Drinking();
            animalThree.Playing();

            Console.WriteLine(animalOne.Hunger + " " + animalTwo.Thirst + " " + animalThree.Hunger + " " + animalThree.Thirst);
            
        }
    }
}
