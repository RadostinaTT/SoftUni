using System;
using System.Collections.Generic;
using System.Linq;

namespace MinimumOrMaximumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int countLines = int.Parse(Console.ReadLine());
            var stack = new Stack<int>();
            int minValue = int.MaxValue;
            int maxValue = int.MinValue;
            for (int i = 0; i < countLines; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int command = input[0];
                if (command == 1)
                {
                    int newEntry = input[1];
                    stack.Push(newEntry);
                }
                else if (command == 2)
                {
                    if (stack.Count > 0)
                    {
                        stack.Pop();
                    }
                }
                else if (command == 3)
                {
                    foreach (var num in stack)
                    {
                        if (maxValue <= num)
                        {
                            maxValue = num;
                        }
                    }
                    if (stack.Count > 0)
                    {
                        Console.WriteLine(maxValue);
                    }
                    
                }
                else if (command == 4)
                {
                    foreach (var num in stack)
                    {
                        if (minValue >= num)
                        {
                            minValue = num;
                        }
                    }
                    if (stack.Count > 0)
                    {
                        Console.WriteLine(minValue);
                    }
                }
            }
            if (stack.Count == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(string.Join(", ", stack));
            }
           
        }
    }
}
