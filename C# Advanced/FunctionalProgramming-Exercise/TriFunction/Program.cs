using System;

namespace TriFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            var names = Console.ReadLine().Split();

            Func<string, int, bool> sumOfChars = (a, b) =>
            {
                var sum = 0;
                for (int i = 0; i < a.Length; i++)
                {
                    sum += a[i];
                }
                if (sum >= b)
                {
                    return true;
                }

                return false;
            };

            foreach (var name in names)
            {
                if (sumOfChars(name, number))
                {
                    Console.WriteLine(name);
                    break;
                }
            }
            
        }
    }
}
