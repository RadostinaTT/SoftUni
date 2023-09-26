using System;
using System.Linq;

namespace JaggedArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int countRows = int.Parse(Console.ReadLine());
            int[][] jagged = new int[countRows][];
            for (int row = 0; row < jagged.Length; row++)
            {
                int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
                jagged[row] = new int[numbers.Length];
                for (int col = 0; col < jagged[row].Length; col++)
                {
                    jagged[row][col] = numbers[col];
                }
            }
            //for (int row = 0; row < jagged.Length; row++)
            //{
            //    Console.WriteLine(string.Join(" ",jagged[row]));
            //}
            for (int row = 0; row < jagged.Length - 1; row++)
            {
                if (jagged[row].Length == jagged[row + 1].Length)
                {
                    for (int col = 0; col < jagged[row].Length; col++)
                    {
                        jagged[row][col] *= 2;
                        jagged[row + 1][col] *= 2;

                    }
                }
                else
                {
                    for (int col = 0; col < jagged[row].Length; col++)
                    {
                        jagged[row][col] /= 2;
                        
                    }
                    for (int col = 0; col < jagged[row + 1].Length; col++)
                    {
                        jagged[row + 1][col] /= 2;
                    }
                }
            }
            while (true)
            {
                string[] command = Console.ReadLine().Split();
                if (command[0] == "End")
                {
                    break;
                }
                else if(command[0] == "Add")
                {
                    int row = int.Parse(command[1]);
                    int col = int.Parse(command[2]);
                    int value = int.Parse(command[3]);
                    if ((row < 0) || (row > jagged.Length - 1) ||
                        (col < 0) || (col > jagged[row].Length - 1))
                    {
                        continue;
                    }
                    else
                    {
                        jagged[row][col] += value;
                    }
                }
                else if (command[0] == "Subtract")
                {
                    int row = int.Parse(command[1]);
                    int col = int.Parse(command[2]);
                    int value = int.Parse(command[3]);
                    if ((row < 0) || (row > jagged.Length - 1) ||
                        (col < 0) || (col > jagged[row].Length - 1))
                    {
                        continue;
                    }
                    else
                    {
                        jagged[row][col] -= value;
                    }
                }
            }

            for (int row = 0; row < jagged.Length; row++)
            {
                Console.WriteLine(string.Join(" ", jagged[row]));
            }
        }
    }
}
