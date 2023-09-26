using System;
using System.Collections.Generic;
using System.Linq;

namespace FashionBoutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] clothes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int capacity = int.Parse(Console.ReadLine());
            int countRacks = 1;
            Stack<int> stack = new Stack<int>(clothes);
            int currentCapacity = capacity;
            int countStack = stack.Count;

            while (stack.Count > 0)
            {
                if (stack.Peek() <= currentCapacity)
                {
                    currentCapacity -= stack.Pop();
                }
                else
                {
                    countRacks++;
                    currentCapacity = capacity;

                }
            }
            if (clothes.Length == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(countRacks);
            }
            

        }
    }
}
