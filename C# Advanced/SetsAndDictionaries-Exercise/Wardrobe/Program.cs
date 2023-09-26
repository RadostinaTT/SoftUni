using System;
using System.Collections.Generic;

namespace Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int countEntries = int.Parse(Console.ReadLine());
            var wardrobe = new Dictionary<string, Dictionary<string, int>>();
            for (int i = 0; i < countEntries; i++)
            {
                string input = Console.ReadLine();
                var colorPart = input.Split(" -> ");
                var color = colorPart[0];
                var clothesPart = colorPart[1].Split(",", StringSplitOptions.RemoveEmptyEntries);
                if (!wardrobe.ContainsKey(color))
                {
                    wardrobe.Add(color, new Dictionary<string, int>());
                }
                for (int j = 0; j < clothesPart.Length; j++)
                {
                    if (!wardrobe[color].ContainsKey(clothesPart[j]))
                    {
                        wardrobe[color].Add(clothesPart[j], 0);
                    }

                    wardrobe[color][clothesPart[j]]++;
                    
                }
            }

            string[] searchFor = Console.ReadLine().Split();
            string searchedColor = searchFor[0];
            string searchedClothes = searchFor[1];

            foreach (var color in wardrobe)
            {
                Console.WriteLine($"{color.Key} clothes:");
                foreach (var cloth in color.Value)
                {
                    
                    if (color.Key == searchedColor && cloth.Key == searchedClothes)
                    {
                        Console.WriteLine($"* {cloth.Key} - {cloth.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {cloth.Key} - {cloth.Value}");
                    }
                }
            }
        }
    }
}
