using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicQueueOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] parameters = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var queue = new Queue<int>();
            int elementsToEnqueue = parameters[0];
            int elementsToDequeue = parameters[1];
            int elementToSearch = parameters[2];
            int smallestNumber = int.MaxValue;
            for (int i = 0; i < elementsToEnqueue; i++)
            {
                queue.Enqueue(numbers[i]);
            }
            for (int j = 0; j < elementsToDequeue; j++)
            {
                queue.Dequeue();
            }

            if (queue.Count == 0)
            {
                Console.WriteLine(0);
            }
            else if (queue.Contains(elementToSearch))
            {
                Console.WriteLine("true");
            }
            else
            {
                foreach (var num in queue)
                {
                    if (num <= smallestNumber)
                    {
                        smallestNumber = num;
                    }
                }
                Console.WriteLine(smallestNumber);
            }
        }
    }
}
