using System;
using System.Linq;

namespace Miner
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizeMatrix = int.Parse(Console.ReadLine());
            var directions = Console.ReadLine().Split();
            var matrix = new char[sizeMatrix, sizeMatrix];
            int startRow = -1;
            int startCol = -1;
            int coalsOnField = 0;
            int coalCollected = 0;
            bool GameOver = false;
            bool AllCoalCollected = false;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];
                    if (input[col] == 's')
                    {
                        startRow = row;
                        startCol = col;
                    }
                    else if (input[col] == 'c')
                    {
                        coalsOnField++;
                    }
                }
            }
            int currentRow = startRow;
            int currentCol = startCol;

            for (int i = 0; i < directions.Length; i++)
            {
                var command = directions[i];
                if (command == "up")
                {
                    if (IsInRange(matrix, currentRow - 1, currentCol))
                    {
                        currentRow -= 1;
                        if (matrix[currentRow, currentCol] == 'c')
                        {
                            coalCollected++;
                            matrix[currentRow, currentCol] = '*';
                            if (coalCollected == coalsOnField)
                            {
                                AllCoalCollected = true;
                                break;
                            }
                        }
                        if (matrix[currentRow, currentCol] == 'e')
                        {
                            GameOver = true;
                            break;
                        }
                    }
                }
                else if (command == "left")
                {
                    if (IsInRange(matrix, currentRow, currentCol - 1))
                    {
                        currentCol -= 1;
                        if (matrix[currentRow, currentCol] == 'c')
                        {
                            coalCollected++;
                            matrix[currentRow, currentCol] = '*';
                            if (coalCollected == coalsOnField)
                            {
                                AllCoalCollected = true;
                                break;
                            }
                        }
                        if (matrix[currentRow, currentCol] == 'e')
                        {
                            GameOver = true;
                            break;
                        }
                    }
                }
                else if (command == "right")
                {
                    if (IsInRange(matrix, currentRow, currentCol + 1))
                    {
                        currentCol += 1;
                        if (matrix[currentRow, currentCol] == 'c')
                        {
                            coalCollected++;
                            matrix[currentRow, currentCol] = '*';
                            if (coalCollected == coalsOnField)
                            {
                                AllCoalCollected = true;
                                break;
                            }
                        }
                        if (matrix[currentRow, currentCol] == 'e')
                        {
                            GameOver = true;
                            break;
                        }
                    }
                }
                else if (command == "down")
                {
                    if (IsInRange(matrix, currentRow + 1, currentCol))
                    {
                        currentRow += 1;
                        if (matrix[currentRow, currentCol] == 'c')
                        {
                            coalCollected++;
                            matrix[currentRow, currentCol] = '*';
                            if (coalCollected == coalsOnField)
                            {
                                AllCoalCollected = true;
                                break;
                            }
                        }
                        if (matrix[currentRow, currentCol] == 'e')
                        {
                            GameOver = true;
                            break;
                        }
                    }
                }
            }
            

            if (GameOver)
            {
                Console.WriteLine($"Game over! ({currentRow}, {currentCol})");
            }
            else if (AllCoalCollected)
            {
                Console.WriteLine($"You collected all coals! ({currentRow}, {currentCol})");
            }
            else
            {
                var remainingCoals = coalsOnField - coalCollected;
                Console.WriteLine($"{remainingCoals} coals left. ({currentRow}, {currentCol})");
            }
        }

        static bool IsInRange(char[,] matrix, int row, int col)
        {
            if (row >= 0 && row < matrix.GetLength(0) && col >= 0 && col < matrix.GetLength(1))
            {
                return true;
            }
            return false;
        }
    }
}
