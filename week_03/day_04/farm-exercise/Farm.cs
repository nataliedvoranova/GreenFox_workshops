using System;
using System.Collections.Generic;
using System.Text;

namespace farm_exercise
{
    /*it has list of Animals
    it has slots which defines the number of free places for animals
    Breed() -> creates a new animal if there's place for it
    Slaughter() -> removes the least hungry animal*/
    class Farm
    {
        List<Animal> animals = new List<Animal>();
        public int freePlaces;

        public void Breed()
        {
            Animal newAnimal = new Animal();
            if (freePlaces> animals.Count)
            {
                animals.Add(newAnimal);
            }

        }
        public void Slaughter ()
        {
            foreach (var animal in animals)
            {
                
            }
        }
    }
}
