using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicStackOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] parameters = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var stack = new Stack<int>();
            int elementsToPush = parameters[0];
            int elementsToPop = parameters[1];
            int elementToSearch = parameters[2];
            int smallestNumber = int.MaxValue;
            for (int i = 0; i < elementsToPush; i++)
            {
                stack.Push(numbers[i]);
            }
            for (int j = 0; j < elementsToPop; j++)
            {
                stack.Pop();
            }

            if (stack.Count == 0)
            {
                Console.WriteLine(0);
            }
            else if (stack.Contains(elementToSearch))
            {
                Console.WriteLine("true");
            }
            else
            {
                foreach (var num in stack)
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
