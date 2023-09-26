using System;
using System.Collections.Generic;
using System.Linq;

namespace SetsOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int firstSet = sizes[0];
            int secondSet = sizes[1];
            var firstList = new HashSet<int>();
            var secondList = new HashSet<int>();
            for (int i = 0; i < firstSet; i++)
            {
                int input = int.Parse(Console.ReadLine());
                firstList.Add(input);
            }
            for (int i = 0; i < secondSet; i++)
            {
                int input = int.Parse(Console.ReadLine());
                secondList.Add(input);
            }

            foreach (var num1 in firstList)
            {
                foreach (var num2 in secondList)
                {
                    if (num1 == num2)
                    {
                        Console.Write(num1 + " ");
                    }
                }
            }
        }
    }
}
