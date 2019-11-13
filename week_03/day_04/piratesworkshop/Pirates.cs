using System;
using System.Collections.Generic;
using System.Text;

namespace piratesworkshop
{
    /*Create a `Pirate` class.  While you can add other fields and methods, you must have these methods:-
- `DrinkSomeRum()` - intoxicates the Pirate some
- `HowsItGoingMate()` - when called, the Pirate replies, if `DrinkSomeRun` was called:-
  - 0 to 4 times, "Pour me anudder!"
  - else, "Arghh, I'ma Pirate. How d'ya d'ink its goin?", the pirate passes out and sleeps it off.
  - `Die()` - this kills off the pirate, in which case, DrinkSomeRum, etc. just result in `he's dead`.
- `Brawl(x)` - where pirate fights another pirate (if that other pirate is alive) and there's a 1/3 chance, 1 dies, the other dies or they both pass out.
*/

    class Pirate
    {
        public string Name { get; private set; }
        public int Drunkness { get; set; } = 0;
        public bool IsDead { get; private set; } = false;
        public bool IsPassedOut { get;  set; } = false;
        public bool IsCaptain { get; set; } = false;
        public int Replies { get; set; } = 0;
        private string passedOutMessage = "He's passed out.";

        public Pirate(string name)
        {
            Name = name;
        }
        public Pirate()
        {

        }
        public void DrinkSomeRum()
        {
            
            if (IsDead == true)
            {
                Console.WriteLine("Dead don't drink.");
            }
            else if (Drunkness < 4)
            {
                Drunkness++;
                Console.WriteLine($"{Name} drank some rum.");
            }
            else if (Drunkness == 4)
            {
                Drunkness++;
                Console.WriteLine($"{Name} drank some rum and passed out.");
                IsPassedOut = true;
            }
            else
            {
                Console.WriteLine($"{Name} is already passed out.");
            }
        }
       
        public void HowIsItGoindMate ()
        {
            if (Drunkness <4)
            {
                Console.WriteLine("Pour me anudder!");
                DrinkSomeRum();
            }
            else if (IsPassedOut == true && !IsDead)
            {
                Console.WriteLine(passedOutMessage);
            }
            else if (IsDead ==true)
            {
                Console.WriteLine("Dead don't reply.");
            }
            else
            {
                Console.WriteLine("Arghh, I'ma Pirate. How d'ya d'ink its goin?");
                DrinkSomeRum();
            }
            
        }
        public void Die()
        {
            IsDead = true;
            if (IsCaptain && IsDead)
            {
                Console.WriteLine($"Captain {Name} died.");
                /*Pirate newcaptain = new Pirate("Barry");
                newcaptain.IsCaptain = true;
                Console.WriteLine($"{newcaptain.Name} is new captain.");*/
            }
            else
            {
               Console.WriteLine($"{this.Name} is dead.");     
            }  
        }
        public void Brawl(Pirate pirateAgainst)
        {
            Random randomNumber = new Random();
            int fightResult = randomNumber.Next(1, 4);
            if (!IsDead && !pirateAgainst.IsDead)
            {
                switch (fightResult)
                {
                    case 1:
                        Die();
                        break;
                    case 2:
                        pirateAgainst.Die();
                        break;
                    default:
                        IsPassedOut = true;
                        pirateAgainst.IsPassedOut = true;
                        Console.WriteLine($"Both {Name} and {pirateAgainst.Name}  passed out.");
                        break;
                }
                /*//either 1/3 chance that:
                pirateOne.Die();
                //1/3 chance that:    
                pirateTwo.Die();
                //1/3 chance that:
                _ = pirateOne.PassedOut + pirateTwo.PassedOut;*/
            }
            else
            {
                Console.WriteLine("Dead pirates can't fight");
            }
        }
    }
}
