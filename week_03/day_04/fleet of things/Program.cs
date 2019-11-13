using System;

namespace FleetOfThings
{

    public class FleetOfThings
    {
        public static void Main(string[] args)
        {
            var fleet = new Fleet();
            // - You have the `Thing` class
            // - You have the `Fleet` class
            // - You have the `FleetOfThings` class with a `Main` method
            // - Download those, use those
            // - In the Main method create a fleet
            // - Achieve this output:s
            // Create a fleet of things to have this output:
            // 1. [ ] Get milk
            // 2. [ ] Remove the obstacles
            // 3. [x] Stand up
            // 4. [x] Eat lunch
            // Hint: You have to create a Print method also

            Thing getMilk = new Thing("Get milk");
            Thing removeObstacles = new Thing("Remove the obstacles");
            Thing standUp = new Thing("Stand up");
            Thing eatLunch = new Thing("Eat lunch");

            getMilk.Complete(false);
            removeObstacles.Complete(false);
            standUp.Complete(true);
            eatLunch.Complete(true);

            fleet.Add(getMilk);
            fleet.Add(removeObstacles);
            fleet.Add(standUp);
            fleet.Add(eatLunch);
        }
        
    }
}
