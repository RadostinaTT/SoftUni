using System;
using System.Linq;

namespace AppliedArithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int> addNum = n => n + 1;
            Func<int, int> multiplyNum = n => n * 2;
            Func<int, int> subtructNum = n => n - 1;
            Action<int[]> printNums = n => Console.WriteLine(string.Join(" ", n));

            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            while (true)
            {
                var command = Console.ReadLine();
                if (command == "end")
                {
                    break;
                }
                else if (command == "add")
                {
                    numbers = numbers.Select(addNum).ToArray();

                }
                else if (command == "multiply")
                {
                    numbers = numbers.Select(multiplyNum).ToArray();

                }
                else if (command == "subtract")
                {
                    numbers = numbers.Select(subtructNum).ToArray();

                }
                else if (command == "print")
                {
                    printNums(numbers);
                }
            }
        }
    }
}
