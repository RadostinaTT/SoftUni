using System;
using System.Collections.Generic;
using System.Linq;

namespace ListOfPredicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int rangeEnd = int.Parse(Console.ReadLine());
            List<int> dividers = Console.ReadLine().Split().Select(int.Parse).ToList();
            //Func<int, bool> dividedFunc = a =>
            //{
            //    foreach (var b in dividers)
            //    {
            //        if (a % b == 0)
            //        {
            //            return true;
            //        }
            //        return false;
            //    }
            //    return false;
            //};

            List<Predicate<int>> predicates = new List<Predicate<int>>();

            dividers.ForEach(d => predicates.Add(x => x % d == 0));

            List<int> result = new List<int>();

            for (int i = 1; i <= rangeEnd; i++)
            {
                var isDivisable = true;
                foreach (var predicate in predicates)
                {
                    if (!predicate(i))
                    {
                        isDivisable = false;
                        break;
                    }

                }

                if (isDivisable)
                {
                    result.Add(i);
                }
            }
            
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
