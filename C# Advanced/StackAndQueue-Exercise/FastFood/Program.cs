using System;
using System.Collections.Generic;
using System.Linq;

namespace FastFood
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantityFood = int.Parse(Console.ReadLine());
            int[] orders = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> queue = new Queue<int>(orders);
            int biggestOrder = 0;
            foreach (var order in queue)
            {
                if (biggestOrder <= order)
                {
                    biggestOrder = order;
                }
            }
            Console.WriteLine(biggestOrder);
            int countOrders = queue.Count;
            for (int i = 0; i < countOrders; i++)
            {
                if (queue.Peek() <= quantityFood)
                {
                    quantityFood -= queue.Dequeue();
                }
                else
                {
                    break;
                }
            }
            if (queue.Count == 0)
            {
                Console.WriteLine("Orders complete");
            }
            else
            {
                Console.WriteLine("Orders left: " + string.Join(' ', queue));
            }
        }
    }
}
