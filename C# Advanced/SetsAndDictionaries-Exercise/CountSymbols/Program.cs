using System;
using System.Collections.Generic;

namespace CountSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            var countSymbols = new SortedDictionary<char, int>();
            string input = Console.ReadLine();
            for (int i = 0; i < input.Length; i++)
            {
                char currentChar = input[i];
                if (!countSymbols.ContainsKey(currentChar))
                {
                    countSymbols.Add(currentChar, 0);
                }
                countSymbols[currentChar]++;
            }
            foreach (var symbol in countSymbols)
            {
                Console.WriteLine($"{symbol.Key}: {symbol.Value} time/s");
            }
        }
    }
}
