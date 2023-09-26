using System;
using System.Collections.Generic;
using System.Linq;

namespace CupAndBottles
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] cupsCapacity = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] bottlesLiters = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Stack<int> stackBottles = new Stack<int>(bottlesLiters);
            Queue<int> queueCups = new Queue<int>(cupsCapacity);

            int wastedWater = 0;
            int leftCurrentCup = 0;
            while (stackBottles.Count > 0 && queueCups.Count > 0)
            {
                int currentBottle = stackBottles.Peek();
                int currentCup = queueCups.Peek();
                
                while (currentBottle < currentCup)
                {
                    currentCup -= currentBottle;
                    stackBottles.Pop();
                    currentBottle = stackBottles.Peek();
                }
                if (currentBottle >= currentCup)
                {
                    queueCups.Dequeue();
                    stackBottles.Pop();
                    wastedWater += currentBottle - currentCup;

                }
            }
            if (stackBottles.Count > 0)
            {
                Console.WriteLine($"Bottles: {string.Join(" ", stackBottles)}");
            }
            if (queueCups.Count > 0)
            {
                Console.WriteLine($"Cups: {string.Join(" ", queueCups)}");
            }

            Console.WriteLine($"Wasted litters of water: {wastedWater}");
        }
    }
}
