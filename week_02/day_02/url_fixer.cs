  
using System;

namespace SimpleReplace
{
    public class SimpleReplace
    {
        public static void Main(string[] args)
        {
           // string url = "https//www.reddit.com/r/nevertellmethebots";

            // Accidentally I got the wrong URL for a funny subreddit. It's probably "odds" and not "bots"
            // Also, the URL is missing a crucial component, find out what it is and insert it too!
            // Try to solve it more than once using different string functions!

           string url = "https//www.reddit.com/r/nevertellmethebots";
            string corrector = url.Replace("bots", "odds").Replace("https//", "https://");
            Console.WriteLine(corrector);

        //2nd solution:

        

            string url2 = "https//www.reddit.com/r/nevertellmethebots";
            string corrector2 = url2.Remove(38).Insert(5, ":").Insert(39, "odds");
            Console.WriteLine(corrector2);

        }
    }
}