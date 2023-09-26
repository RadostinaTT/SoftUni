using System;
using System.Linq;

namespace MaximumSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rowMatrix = dimensions[0];
            int colMatrix = dimensions[1];
            int controlNumber = 3;
            int maxSum = int.MinValue;
            int maxSumRow = -1;
            int maxSumCol = -1;
            int[,] matrix = new int[rowMatrix, colMatrix];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = numbers[col];
                }
            }
            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 2; col++)
                {
                    int currentSum = 0;
                    for (int subRow = 0; subRow < controlNumber; subRow++)
                    {
                        for (int subCol = 0; subCol < controlNumber; subCol++)
                        {
                            currentSum += matrix[row + subRow, col + subCol];
                        }
                    }
                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                        maxSumRow = row;
                        maxSumCol = col;
                    }
                }
            }
            Console.WriteLine("Sum = " + maxSum);

            for (int subRow = 0; subRow < controlNumber; subRow++)
            {
                for (int subCol = 0; subCol < controlNumber; subCol++)
                {
                    Console.Write(matrix[maxSumRow + subRow, maxSumCol + subCol] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
