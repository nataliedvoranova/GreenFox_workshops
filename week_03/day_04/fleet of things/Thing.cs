using System;

namespace FleetOfThings
{
    public class Thing
    {
        private string name;
        private bool completed;

        public Thing(string name)
        {
            this.name = name;
        }

        public void Complete(bool completed)
        {
            if (completed == true)
            {
                Console.WriteLine("[x]" + name);
            }
            else
            {
                Console.WriteLine("[ ]" + name);
            }
        }
        public void Print(Fleet fleet)
        {
            Console.WriteLine(completed.ToString() + name);
        }
    }
}