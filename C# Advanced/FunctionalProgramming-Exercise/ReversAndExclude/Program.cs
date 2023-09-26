using System;
using System.Linq;

namespace ReversAndExclude
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var divisor = int.Parse(Console.ReadLine());

            Func<int[], int[]> reverse = n => n.Reverse().ToArray();

            var filteredNums = reverse(numbers).Where(x => !(x % divisor == 0));
            Console.WriteLine(string.Join(" ", filteredNums));
        }
    }
}
