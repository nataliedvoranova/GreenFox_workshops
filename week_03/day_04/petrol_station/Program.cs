using System;

namespace petrol_station
{
    class Program
    {
        /*Create Station and Car classes
        Station
        GasAmount
        Refill(car) -> decreases the gasAmount by the capacity of the car and increases the cars gasAmount
        Car
        GasAmount
        Capacity
        create constructor for Car where:
        initialize gasAmount -> 0
        initialize capacity -> 100*/
        static void Main(string[] args)
        {
            Car car = new Car(0, 100);
            Station station = new Station();
            Console.WriteLine(car.GasAmountCar + " " + car.Capacity);
            Console.WriteLine(station.GasAmount);
            station.Refill(car);
            Console.WriteLine();
            Console.WriteLine(car.GasAmountCar +" "+ car.Capacity);
            Console.WriteLine(station.GasAmount);

        }
    }
}
