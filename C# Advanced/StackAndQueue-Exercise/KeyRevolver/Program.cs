using System;
using System.Collections.Generic;
using System.Linq;

namespace KeyRevolver
{
    class Program
    {
        static void Main(string[] args)
        {
            int priceBullet = int.Parse(Console.ReadLine());
            int sizeGunBarrel = int.Parse(Console.ReadLine());
            int[] bullets = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] locks = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int valueIntell = int.Parse(Console.ReadLine());

            Queue<int> queueLocks = new Queue<int>(locks);
            Stack<int> stackBullets = new Stack<int>(bullets);
            int countShots = 0;
            int counterReload = 0;
            while (queueLocks.Count > 0 && stackBullets.Count > 0)
            {
                
                int currentBullet = stackBullets.Pop();
                countShots++;

                counterReload++;
                if (queueLocks.Peek() >= currentBullet)
                {
                    queueLocks.Dequeue();
                    Console.WriteLine("Bang!");
                }
                else
                {
                    Console.WriteLine("Ping!");
                }
                if (counterReload == sizeGunBarrel)
                {
                    if (stackBullets.Count > 0)
                    {
                        Console.WriteLine("Reloading!");
                        counterReload = 0;
                    }
                }
            }
            valueIntell -= countShots * priceBullet;

            if (queueLocks.Count == 0)
            {
                Console.WriteLine($"{stackBullets.Count} bullets left. Earned ${valueIntell}");
            }
            else
            {
                Console.WriteLine($"Couldn't get through. Locks left: {queueLocks.Count}");
            }
        }
    }
}
