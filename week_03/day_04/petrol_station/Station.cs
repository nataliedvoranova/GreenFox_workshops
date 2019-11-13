using System;
using System.Collections.Generic;
using System.Text;

namespace petrol_station
{
    /*Station
            GasAmount
            Refill(car) -> decreases the gasAmount by the capacity of the car and increases the cars gasAmount*/
    class Station
    {
        public int GasAmount { get; set; } = 50;
        public void Refill(Car car)
        {
            if (GasAmount - car.Capacity >=0)
            {
                GasAmount -= car.Capacity;
                car.GasAmountCar += car.Capacity;
            }
            else
            {
                car.GasAmountCar += GasAmount;
                GasAmount -= GasAmount;
            }
            
        }
    }
}
