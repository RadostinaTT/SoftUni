using System;
using System.Linq;

namespace DiagonalDiffrence
{
    class Program
    {
        static void Main(string[] args)
        {
            int dimension = int.Parse(Console.ReadLine());
            int[,] matrix = new int[dimension, dimension];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = numbers[col];
                }
            }

            int sumFirstDialonal = 0;
            int sumSecondDialonal = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                sumFirstDialonal += matrix[row, row];
            }
            for (int row = matrix.GetLength(0) - 1; row >= 0; row--)
            {
                sumSecondDialonal += matrix[row, matrix.GetLength(0) - 1 - row];
            }
            int diffrence = Math.Abs(sumFirstDialonal - sumSecondDialonal);
            Console.WriteLine(diffrence);
        }
    }
}
