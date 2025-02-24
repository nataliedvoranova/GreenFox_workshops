using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            int currentHours = 14;
            int currentMinutes = 34;
            int currentSeconds = 42;

            // Write a program that prints the remaining seconds (as an integer) from a
            // day if the current time is represented by the variables

            int secondsPerMinute = 60;
            int minutesPerHour = 60;
            int hoursPerDay = 24;

            int secondInDay = hoursPerDay * minutesPerHour * secondsPerMinute;
            int secLeft = secondInDay - ((currentHours * minutesPerHour* secondsPerMinute) + (currentMinutes *secondsPerMinute) + currentSeconds);
            

            Console.WriteLine("remaining seconds: " + secLeft + " from total: " + secondInDay);
        }
    }
}