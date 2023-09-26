using System;
using System.Linq;

namespace PredicateForNames
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenghtNeeded = int.Parse(Console.ReadLine());
            Func<string, bool> lenghtNames = n => n.Length <= lenghtNeeded;
            string[] names = Console.ReadLine().Split().Where(s => lenghtNames(s)).ToArray();
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
