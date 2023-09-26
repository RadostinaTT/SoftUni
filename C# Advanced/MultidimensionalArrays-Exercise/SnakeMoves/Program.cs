using System;
using System.Linq;

namespace SnakeMoves
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int matrixRow = dimensions[0];
            int matrixCol = dimensions[1];
            char[,] matrix = new char[matrixRow, matrixCol];
            string snake = Console.ReadLine();
            int indexString = 0;
            int counterRows = 0;
            while (counterRows < matrixRow)
            {
                if (counterRows % 2 == 0)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        matrix[counterRows, col] = snake[indexString];
                        indexString++;
                        if (indexString == snake.Length)
                        {
                            indexString = 0;
                        }
                    }
                    counterRows++;
                }
                else
                {
                    for (int col = matrix.GetLength(1) - 1; col >= 0; col--)
                    {
                        matrix[counterRows, col] = snake[indexString];
                        indexString++;
                        if (indexString == snake.Length)
                        {
                            indexString = 0;
                        }
                    }
                    counterRows++;
                }
            }
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row,col]);
                }
                Console.WriteLine();
            }
        }
    }
}
