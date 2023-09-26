using System;
using System.Collections.Generic;

namespace PeriodicTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int countEntries = int.Parse(Console.ReadLine());
            var elements = new SortedSet<string>();
            for (int i = 0; i < countEntries; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < input.Length; j++)
                {
                    elements.Add(input[j]);
                }
            }
            Console.WriteLine(string.Join(" ", elements));
        }
    }
}
