using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lionkingaccount.Models
{
    public class BankAccount
    {
        public string Name { get; set; }
        public double Balance { get; set; }
        public string AnimalType { get; set; }
        public bool IsKing { get; set; }

        public BankAccount(string name, double balance, string animalType)
        {
            Name = name;
            Balance = balance;
            AnimalType = animalType;
            IsKing = false;
        }
        public BankAccount(string name, double balance, string animalType,bool isKing)
        {
            Name = name;
            Balance = balance;
            AnimalType = animalType;
            IsKing = isKing;
        }
    }
}
