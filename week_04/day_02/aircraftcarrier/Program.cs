using System;

namespace aircraftcarrier
{
    class Program
    {
        static void Main(string[] args)
        {
            F35 aircraft = new F35();
            aircraft.Refill(10);
            Console.WriteLine(aircraft.GetStatus());
            Console.WriteLine();

            Carrier goodGuys = new Carrier(50, 50);
            goodGuys.AddAircraft(new F16());
            goodGuys.AddAircraft(new F16());
            goodGuys.AddAircraft(new F16());
            goodGuys.AddAircraft(new F16());
            goodGuys.AddAircraft(new F16());
            goodGuys.Fill();

            Carrier badGuys = new Carrier(50, 100);
            badGuys.AddAircraft(new F35());
            badGuys.AddAircraft(new F35());
            badGuys.AddAircraft(new F35());
            badGuys.AddAircraft(new F35());
            badGuys.AddAircraft(new F35());
            badGuys.AddAircraft(new F35());

            goodGuys.Fight(badGuys);
            Console.WriteLine(badGuys.GetStatus());

        }
    }
}
