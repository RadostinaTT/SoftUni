using System;
using System.Collections.Generic;
using System.Linq;

namespace TruckTour
{
    class Program
    {
        static void Main(string[] args)
        {
            int countPumps = int.Parse(Console.ReadLine());
            long fuel = 0;
            Queue<long[]> queue = new Queue<long[]>();
            for (int i = 0; i < countPumps; i++)
            {
                queue.Enqueue(Console.ReadLine().Split().Select(long.Parse).ToArray());
                
            }

            for (int i = 0; i < countPumps; i++)
            {
                long[] current = queue.Peek();
                bool IsFuelEnough = true;

                for (int j = 0; j < queue.Count; j++)
                {
                    fuel += current[0];
                    if (fuel < current[1])
                    {
                        IsFuelEnough = false;

                        for (int k = queue.Count - j + 1; k > 0; k--)
                        {
                            queue.Enqueue(queue.Dequeue());
                        }
                        break;
                    }
                    fuel -= current[1];
                    queue.Enqueue(queue.Dequeue());
                    current = queue.Peek();
                }
                if (IsFuelEnough)
                {
                    Console.WriteLine(i);
                    return;
                }

                fuel = 0;

            }
        }
    }
}
