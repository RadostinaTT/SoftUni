using System;
using System.Collections.Generic;
using System.Linq;

namespace Bombs
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizeMatrix = int.Parse(Console.ReadLine());
            var matrix = new int[sizeMatrix, sizeMatrix];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];
                }
            }
            var coordinates = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < coordinates.Length; i++)
            {
                var current = coordinates[i];
                var parts = current.Split(',', StringSplitOptions.RemoveEmptyEntries);
                int row = int.Parse(parts[0]);
                int col = int.Parse(parts[1]);
                var bomb = 0;
                if (matrix[row, col] > 0)
                {
                    bomb = matrix[row, col];
                    matrix[row, col] = 0;
                }
                                
                if (IsInRange(matrix, row - 1, col - 1) && !IsDead(matrix, row - 1, col - 1))
                {
                    matrix[row - 1, col - 1] -= bomb;
                }
                if (IsInRange(matrix, row - 1, col) && !IsDead(matrix, row - 1, col))
                {
                    matrix[row - 1, col] -= bomb;
                }
                if (IsInRange(matrix, row - 1, col + 1) && !IsDead(matrix, row - 1, col + 1))
                {
                    matrix[row - 1, col + 1] -= bomb;
                }
                if (IsInRange(matrix, row, col - 1) && !IsDead(matrix, row, col - 1))
                {
                    matrix[row, col - 1] -= bomb;
                }
                if (IsInRange(matrix, row, col + 1) && !IsDead(matrix, row, col + 1))
                {
                    matrix[row, col + 1] -= bomb;
                }
                if (IsInRange(matrix, row + 1, col - 1) && !IsDead(matrix, row + 1, col - 1))
                {
                    matrix[row + 1, col - 1] -= bomb;
                }
                if (IsInRange(matrix, row + 1, col) && !IsDead(matrix, row + 1, col))
                {
                    matrix[row + 1, col] -= bomb;
                }
                if (IsInRange(matrix, row + 1, col + 1) && !IsDead(matrix, row + 1, col + 1))
                {
                    matrix[row + 1, col + 1] -= bomb;
                }
                
            }
            List<int> aliveCells = new List<int>();
            foreach (var item in matrix)
            {
                if (item > 0)
                {
                    aliveCells.Add(item);
                }
            }

            Console.WriteLine($"Alive cells: {aliveCells.Count}");
            Console.WriteLine($"Sum: {aliveCells.Sum()}");

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                };
                Console.WriteLine();
            }
        }

        static bool IsInRange(int[,] matrix, int row, int col)
        {
            if (row >= 0 && row < matrix.GetLength(0) && col >= 0 && col < matrix.GetLength(1))
            {
                return true;
            }
            return false;
        }
        static bool IsDead(int[,] matrix, int row, int col)
        {
            if (matrix[row, col] <= 0)
            {
                return true;
            }
            return false;
        }
    }
}
