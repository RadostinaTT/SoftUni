using System;
using System.Collections.Generic;

namespace SongsQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] songs = Console.ReadLine().Split(", ");
            Queue<string> queue = new Queue<string>(songs);
            while (queue.Count > 0)
            {
                string command = Console.ReadLine();
                if (command.StartsWith("Play"))
                {
                    queue.Dequeue();
                }
                else if (command.StartsWith("Add"))
                {
                    string newSong = command.Replace("Add ", "");
                    if (queue.Contains(newSong))
                    {
                        Console.WriteLine(newSong + " is already contained!");
                    }
                    else
                    {
                        queue.Enqueue(newSong);
                    }
                    
                }
                else if (command.StartsWith("Show"))
                {
                    Console.WriteLine(string.Join(", ", queue));
                }

            }
            if (queue.Count == 0)
            {
                Console.WriteLine("No more songs!");
            }
        }
    }
}
