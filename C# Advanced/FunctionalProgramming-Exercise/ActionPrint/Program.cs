using System;

namespace ActionPrint
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = Console.ReadLine().Split();
            Action<string> printNames = name => Console.WriteLine(name);
            foreach (var name in names)
            {
                printNames(name);
            }
        }
    }
}
