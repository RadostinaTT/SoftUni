using System;

namespace KnightsOfHonor
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
            Action<string> printNames = name => Console.WriteLine("Sir " + name);
            foreach (var name in names)
            {
                printNames(name);
            }
        }
    }
}
