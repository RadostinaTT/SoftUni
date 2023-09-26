using System;
using System.Linq;

namespace CustomMinFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Func<int[], int> smallesInt = n => n.Min();
            Console.WriteLine(smallesInt(numbers));
        }
    }
}
