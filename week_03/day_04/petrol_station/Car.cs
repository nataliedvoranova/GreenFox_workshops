using System;
using System.Collections.Generic;
using System.Text;

namespace petrol_station
{
    /*Car
            GasAmount
            Capacity
            create constructor for Car where:*/
    class Car
    {
        public int GasAmountCar { get; set; }
        public int Capacity { get; set; }
        public Car(int gasAmountCar, int capacity)
        {
            GasAmountCar = gasAmountCar;
            Capacity = capacity;
        }
    }
}
