using System;
using System.Collections.Generic;
using System.Text;

namespace Animal
{
    class Class_animal
    {
        public int Hunger { get; set; }
        public int Thirst { get; set; }

        public void Eating ()
         {
            Hunger--;

        }
        public void Drinking()
        {
           Thirst--;
        }
        public void Playing()
        {
           Thirst++;
           Hunger++;
        }
       
    }
}
