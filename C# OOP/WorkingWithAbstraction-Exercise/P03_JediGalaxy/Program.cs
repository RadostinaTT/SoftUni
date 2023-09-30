using System;
using System.Linq;

namespace P03_JediGalaxy
{
    class Program
    {
        static void Main()
        {
            int[] dimestions = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int matrixRows = dimestions[0];
            int matrixCols = dimestions[1];

            int[,] matrix = new int[matrixRows, matrixCols];

            int value = 0;
            for (int row = 0; row < matrixRows; row++)
            {
                for (int col = 0; col < matrixCols; col++)
                {
                    matrix[row, col] = value++;
                }
            }

            long sum = 0;
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "Let the Force be with you")
                {
                    break;
                }
                int[] ivoCoordinates = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                int[] evilCoordinates = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                int evilRow = evilCoordinates[0];
                int evilCol = evilCoordinates[1];

                while (evilRow >= 0 && evilCol >= 0)
                {
                    if (IsInside(matrix, evilRow, evilCol))
                    {
                        matrix[evilRow, evilCol] = 0;
                    }
                    evilRow--;
                    evilCol--;
                }

                int ivoRow = ivoCoordinates[0];
                int ivoCol = ivoCoordinates[1];

                while (ivoRow >= 0 && ivoCol < matrix.GetLength(1))
                {
                    if (IsInside(matrix, ivoRow, ivoCol))
                    {
                        sum += matrix[ivoRow, ivoCol];
                    }

                    ivoCol++;
                    ivoRow--;
                }
            }

            Console.WriteLine(sum);

        }

        static bool IsInside(int[,] matrix, int row, int col)
        {
            if (row >= 0 && row < matrix.GetLength(0) && col >= 0 && col < matrix.GetLength(1))
            {
                return true;
            }
            return false;
        }
    }
}
