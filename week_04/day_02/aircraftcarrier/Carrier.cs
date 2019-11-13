using System;
using System.Collections.Generic;
using System.Text;

namespace aircraftcarrier
{
    class Carrier
    {
        private List<Aircraft> listOfAircrafts;
        private int storedAmmo;
        protected int hp;
        protected int totalDamage;

        public Carrier (int ammo, int hp)
        {
            listOfAircrafts = new List<Aircraft>();
            storedAmmo = ammo;
            this.hp = hp;
        }

        public void AddAircraft(Aircraft aircraft)
        {
            listOfAircrafts.Add(aircraft);
        }

        public void Fill()
        {
            /*It should fill all the aircraft with ammo and subtract the needed ammo from the ammo storage
            If there is not enough ammo then it should start to fill the aircrafts with priority first
            If there is no ammo when this method is called, it should throw an exception*/
            if (storedAmmo == 0)
            {
                throw new Exception("No ammo");
            }
            int ammoNeeded = 0;
            foreach (var aircraft in listOfAircrafts)
            {
                ammoNeeded += aircraft.MaxAmmo - aircraft.CurrentAmmo;
            }
            var aircraftInQueue = new List<Aircraft>();

            if (ammoNeeded > storedAmmo)
            {
                aircraftInQueue.AddRange(GetAircrafts(true));
                aircraftInQueue.AddRange(GetAircrafts(false));
            }

            aircraftInQueue = listOfAircrafts;

            foreach (var aircraft in aircraftInQueue)
            {
                storedAmmo = aircraft.Refill(storedAmmo);
                if (storedAmmo == 0)
                {
                    break;
                }
            }

        }

        private List<Aircraft> GetAircrafts(bool isPrior)
        {
            var result = new List<Aircraft>();
            foreach (var aircraft in listOfAircrafts)
            {
                if (isPrior)
                {
                    listOfAircrafts.Add(aircraft);
                }
            }
            return result;
        }

        public void Fight(Carrier teamAgainst)
        {
            /*It should take another carrier as a reference parameter and fire all the ammo from the aircrafts 
             * to it, then subtract all the damage from its health points*/ 
            foreach (var aircraft in listOfAircrafts)
            {
                totalDamage += (aircraft.CurrentAmmo - aircraft.BaseDamage);
                aircraft.CurrentAmmo = 0;
            }

            teamAgainst.hp -= totalDamage;
        }

        public string GetStatus ()
        {
            string message = "";
            if (hp<=0)
            {
               message = "It's dead Jim.";
            }
            else
            {
                 message= $"HP: {hp}, Aircraft count {listOfAircrafts.Count}, Ammo Storage: {storedAmmo}, Total Damage {totalDamage}";
                foreach (var aircraft in listOfAircrafts)
                {
                    aircraft.GetAircraftType1();
                }
            }

            return message;
        }
    }
}
