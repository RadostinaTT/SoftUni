using System;
using System.Linq;
using System.Collections.Generic;

namespace TheV_Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, SortedSet<string>>> collection = new Dictionary<string, Dictionary<string, SortedSet<string>>>();

            while (true)
            {
                var input = Console.ReadLine();
                if (input.StartsWith("Statistics"))
                {
                    break;
                }
                var parts = input.Split(" ",StringSplitOptions.RemoveEmptyEntries);
                var vlogger = parts[0];
                var command = parts[1];
                if (command == "joined")
                {
                    if (!collection.ContainsKey(vlogger))
                    {
                        collection.Add(vlogger, new Dictionary<string, SortedSet<string>>());
                        collection[vlogger].Add("followers", new SortedSet<string>());
                        collection[vlogger].Add("following", new SortedSet<string>());
                    }
                }
                else if(command == "followed")
                {
                    var followerVlogger = vlogger;
                    var followingVlogger = parts[2];
                    if (collection.ContainsKey(followerVlogger) &&  collection.ContainsKey(followingVlogger) && followerVlogger != followingVlogger)
                    {
                        if (!collection[followerVlogger]["following"].Contains(followingVlogger))
                        {
                            collection[followerVlogger]["following"].Add(followingVlogger);
                        }
                        if (!collection[followingVlogger]["followers"].Contains(followerVlogger))
                        {
                            collection[followingVlogger]["followers"].Add(followerVlogger);
                        }
                    }

                }
            }
            Console.WriteLine($"The V-Logger has a total of {collection.Count} vloggers in its logs.");
            int counter = 1;
            foreach (var vlogger in collection.OrderByDescending(x => x.Value["followers"].Count).ThenBy(y => y.Value["following"].Count))
            {
                Console.WriteLine($"{counter}. {vlogger.Key} : {vlogger.Value["followers"].Count} followers, {vlogger.Value["following"].Count} following");
                if (counter == 1)
                {
                    foreach (var follower in vlogger.Value["followers"])
                    {
                        Console.WriteLine($"*  {follower}");
                    }
                }
                counter++;
            }
        }
    }
}
