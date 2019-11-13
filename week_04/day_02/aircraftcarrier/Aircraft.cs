using System;
using System.Collections.Generic;
using System.Text;

namespace aircraftcarrier
{
    public abstract class Aircraft
    {
        public int CurrentAmmo { get; set; } = 0;
        public int MaxAmmo { get; set; }
        public int BaseDamage { get; set; }
        public bool isAmmoPrior { get; set; }
        public int Damage
        { get
            { return CurrentAmmo * BaseDamage; }
        }
        public Aircraft()
        {
           
        }

        public int Fight()
        {
            /*It should use all the ammo (set it to 0) and it should return the damage it deals
            The damage dealt is calculated by multiplying the base damage by the ammunition*/
            CurrentAmmo = 0;
            return Damage;

            /* if (CurrentAmmo > 0)
            {
                Console.WriteLine($"Damage dealt: {MaxAmmo * BaseDamage}");
                CurrentAmmo = 0;
            }
            else
            {
                Console.WriteLine("No ammo for a fight");
            }*/
        }

        public int Refill(int refillAmmo)
        {
            /*It should take a number as parameter and subtract as much ammo as possible
            It can't have more ammo than the number or the max ammo (can't get more ammo than what's coming from the parameter or the max ammo of the aircraft)
            It should return the remaining ammo
            Eg. Filling an empty F35 with 300 would completely fill the storage of the aircraft and would return the remaining 288*/
            if (refillAmmo < (MaxAmmo- CurrentAmmo))
            {
                int missingAmmo = MaxAmmo - refillAmmo;
                CurrentAmmo += refillAmmo;
                refillAmmo -= CurrentAmmo;
                
                Console.WriteLine("Current ammo: " + CurrentAmmo);
                Console.WriteLine(missingAmmo + " is missing to be fully refilled");
            }
            else if (refillAmmo >= (MaxAmmo - CurrentAmmo) )
            {
                refillAmmo -= (MaxAmmo - CurrentAmmo);
                CurrentAmmo = MaxAmmo;
                Console.WriteLine("Current ammo: " + CurrentAmmo);
                Console.WriteLine("Ammo left: " +refillAmmo);
            }
            
            return refillAmmo;

            /*for (int i = CurrentAmmo; i < MaxAmmo; i++)
                        {
                            refillAmmo--;
                            CurrentAmmo++;
                        }
                        return reffilAmmo*/
        }

        public string GetAircraftType1()
        {
            string typeOfAircraft = this.GetType().ToString();
            string subType = typeOfAircraft.Substring(typeOfAircraft.Length - 3, 3);
            return subType;
        }

        //public abstract string GetAircraftType2();

        public string GetStatus()
        {
            //return Type F35, Ammo: 10, Base Damage: 50, All Damage: 500
            return $"Type: {GetAircraftType1()}, Ammo: {CurrentAmmo}, Base Damage: {BaseDamage}, All Damage: {Damage}, Has Priority for Reffil: {(isAmmoPrior? "yes": "no")}";
        }
        
    }

    class F16: Aircraft
    {
        public F16()
        {
            MaxAmmo = 8;
            BaseDamage = 30;
            isAmmoPrior = false;
        }
    }

    class F35 : Aircraft
    {
        public F35 ()
        {
            MaxAmmo = 12;
            BaseDamage = 50;
            isAmmoPrior = true;
        }
        
    }
}
