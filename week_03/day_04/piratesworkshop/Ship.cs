using System;
using System.Collections.Generic;
using System.Text;

namespace piratesworkshop
{
    /*The `Ship` stores `Pirate`-s instances in a list as the crew and has one captain who is also a `Pirate`.
    - When a ship is created it doesn't have a crew or a captain.
    - The ship can be filled with pirates and a captain via `FillShip()` method.
        - Filling the ship with a captain and random number of pirates.
    - Ships should be represented in a nice way on command line including information about
        - captains consumed rum, state (passed out / died)
        - number of alive pirates in the crew
    - Ships should have a method to battle other ships: `ship.Battle(otherShip)`
        - should return `true` if the actual ship (`this`) wins
        - the ship should win if its calculated score is higher
        - calculate score: Number of Alive pirates in the crew - Number of consumed rum by the captain
        - The loser crew has a random number of losses (deaths).
        - The winner captain and crew has a party, including a random number of rum :)*/
    class Ship
    {
        public string ShipName { get; set; }
        public List<Pirate> piratetOnTheShip { get; set; }
        public bool IsCaptainIncluded { get; set; } = false;
        public int CaptainDrunkness
        {
            get
            {
                int CaptainDrunkness = 0;
                foreach (var pirate in piratetOnTheShip)
                {
                    if (pirate.IsCaptain ==true)
                    {
                        CaptainDrunkness = pirate.Drunkness;
                    }
                }
                return CaptainDrunkness;
            }
        }
        public Ship()
        {
            piratetOnTheShip = new List<Pirate>();
        }
        public Ship(string name)
        {
            ShipName = name;
            piratetOnTheShip = new List<Pirate>();
        }
        /*public bool IsCaptainIncluded
        {
            get
            {
                bool IsCaptainIncluded = false;
                foreach (var crewMember in piratetOnTheShip)
                {
                    if (crewMember.IsCaptain)
                    {
                        IsCaptainIncluded = true;
                    }
                }
                return IsCaptainIncluded;
            }      
        }*/
        public void FillShip(Pirate pirate)
        {
                   /* if ((pirate.IsCaptain && !IsCaptainIncluded) || !pirate.IsCaptain)
                    {
                        piratetOnTheShip.Add(pirate);
                    }*/

            if (IsCaptainIncluded == true)
            {
                Console.WriteLine($"Since {ShipName} already has a captain {pirate.Name} was added as crew member.");
                piratetOnTheShip.Add(pirate);
            }
            /*if (pirate.IsCaptain && pirate.IsDead)
            {
                piratetOnTheShip.Add(pirate);
                pirate.IsCaptain = true;
            }*/
            else
            {
                /*Pirate captain = new Pirate();
                piratetOnTheShip.Add(captain);*/
                piratetOnTheShip.Insert(0, pirate);
                IsCaptainIncluded = true;
                //captain.IsCaptain = true;
                pirate.IsCaptain = true;
                Console.WriteLine($"{pirate.Name} was added as a new captain of {ShipName}!");
            }  
        }
        public void ShiptStatus()
        {
            /*-Ships should be represented in a nice way on command line including information about
      - captains consumed rum, state (passed out / died)
        -number of alive pirates in the crew*/

            if (piratetOnTheShip.Count > 0)
            {
                int alive = 0;
                int dead = 0;
                int passedOut = 0;
                foreach (Pirate pirate in piratetOnTheShip)
                { 
                    string status = "Alive";

                    if (pirate.IsDead == true)
                    {
                        status = "Dead";
                        dead++;
                    }
                    else if (pirate.IsPassedOut == true)
                    {
                        status = "Passed Out";
                        passedOut++;
                        alive++;
                    }
                    else
                    {
                        alive++;
                    }
                    
                    Console.WriteLine($"From {ShipName}: { pirate.Name}, who drank {pirate.Drunkness} rum(s) and is {status}");
                }
                Console.WriteLine($"On {ShipName} there is overall {alive} alive, {passedOut} passed out and {dead} dead pirate(s).");
            }
            else
            {
                Console.WriteLine("The ship is empty.");
            }
        }
        /* - Ships should have a method to battle other ships: `ship.Battle(otherShip)`
        - should return `true` if the actual ship (`this`) wins
        - the ship should win if its calculated score is higher
        - calculate score: Number of Alive pirates in the crew - Number of consumed rum by the captain
        - The loser crew has a random number of losses (deaths).
        - The winner captain and crew has a party, including a random number of rum :)*/

        public void Party()
        {
            int passedOutAfterParty = 0;
            Random random = new Random();
            int numberOfRum = random.Next(1, 5);
            foreach (var pirate in piratetOnTheShip)
            {
                if (pirate.IsDead == false)
                {
                    pirate.Drunkness += numberOfRum;
                    if (pirate.Drunkness > 4)
                    {
                       pirate.IsPassedOut = true;
                       passedOutAfterParty++;
                       Console.WriteLine(pirate.Name + " passed out.");
                    }
                }
            }
            Console.WriteLine($"The crew of {ShipName} celebrated victory with {numberOfRum} rum(s) and {passedOutAfterParty} of them passed out.");
        }
        public void LoseLives()
        {
            int deathCount = 0;
            Random randomTwo = new Random();
            int numberOfDeaths = randomTwo.Next(1, piratetOnTheShip.Count);
            foreach (var pirate in piratetOnTheShip)
            {
                if (pirate.IsDead == true)
                {
                    Console.WriteLine($"{ pirate.Name} has died before the battle.");
                }
            }
            for (int i = 1; i < numberOfDeaths; i++)
            {
                
                piratetOnTheShip[i].Die();
                deathCount++;
            }
            Console.WriteLine($"{deathCount} pirate(s) from {ShipName} died in battle.");
        }
        public bool Battle(Ship shipAgainst)
        {
            int score1 = 0;
            int score2 = 0;
            int aliveTwo = 0;
            int aliveThree = 0;

                foreach (Pirate pirate in piratetOnTheShip)
                {
                    if (!pirate.IsDead && !pirate.IsPassedOut)
                    {
                         aliveTwo++;
                    } 
                }
                score1 = aliveTwo - CaptainDrunkness;
                foreach (Pirate pirate in shipAgainst.piratetOnTheShip)
                {
                    if (!pirate.IsDead && !pirate.IsPassedOut)
                    {
                        aliveThree++;
                    }
                }
                score2 = aliveThree - shipAgainst.CaptainDrunkness;
                
            if (score1< score2)
            {
                Console.WriteLine($"{ShipName} has lost the battle.");
                LoseLives();
                shipAgainst.Party();
            }
            else
            {
                Console.WriteLine($"{shipAgainst.ShipName} has lost the battle.");
                shipAgainst.LoseLives();
                Console.WriteLine();
                Party();
                    /*Console.WriteLine($"{pirate.Name} has died in the battle.");*/
                
            }
             return true; 
            
        }
    }
}
