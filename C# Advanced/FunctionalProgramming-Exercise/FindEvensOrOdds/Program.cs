using System;
using System.Linq;

namespace FindEvensOrOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] range = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Predicate<int> isEvenPredicate = n => n % 2 == 0;
            int startNum = range[0];
            int endNum = range[1] + 1;
            var numbers = Enumerable.Range(startNum, endNum - startNum);
            string condition = Console.ReadLine();
            if (condition == "even")
            {
                foreach (var num in numbers)
                {
                    if (isEvenPredicate(num))
                    {
                        Console.Write(num + " ");
                    }
                }
                
            }
            else if (condition == "odd")
            {
                foreach (var num in numbers)
                {
                    if (!isEvenPredicate(num))
                    {
                        Console.Write(num + " ");
                    }
                }
            }
        }
    }
}
