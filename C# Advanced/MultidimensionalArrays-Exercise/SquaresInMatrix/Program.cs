using System;
using System.Linq;

namespace SquaresInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rowMatrix = dimensions[0];
            int colMatrix = dimensions[1];
            int controlNumber = 2;
            char[,] matrix = new char[rowMatrix, colMatrix];
            for (int row = 0; row < rowMatrix; row++)
            {
                char[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
                for (int col = 0; col < colMatrix; col++)
                {
                    matrix[row, col] = input[col];
                }
            }
            int countEqualMatrixes = 0;
            for (int row = 0; row < rowMatrix - 1; row++)
            {
                for (int col = 0; col < colMatrix - 1; col++)
                {
                    char currentChar = matrix[row, col];
                    int countdownEquals = controlNumber * controlNumber;
                    for (int subrow = 0; subrow < controlNumber; subrow++)
                    {
                        for (int subcol = 0; subcol < controlNumber; subcol++)
                        {
                            if (matrix[row + subrow,col + subcol] == currentChar)
                            {
                                countdownEquals--;
                            }
                        }
                    }
                    if (countdownEquals == 0)
                    {
                        countEqualMatrixes++;
                    }
                }
            }
            Console.WriteLine(countEqualMatrixes);
        }
    }
}
