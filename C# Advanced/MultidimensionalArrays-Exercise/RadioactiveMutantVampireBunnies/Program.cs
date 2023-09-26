using System;
using System.Linq;

namespace RadioactiveMutantVampireBunnies
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = dimensions[0];
            int cols = dimensions[1];
            char[,] lair = new char[rows, cols];
            int indexPlayerRow = -1;
            int indexPlayerCol = -1;
            bool IsDead = false;
            bool PlayerWon = false;

            for (int row = 0; row < rows; row++)
            {
                var input = Console.ReadLine();
                for (int col = 0; col < cols; col++)
                {
                    lair[row, col] = input[col];
                    if (input[col] == 'P')
                    {
                        indexPlayerRow = row;
                        indexPlayerCol = col;
                    }
                }
            }

            //for (int row = 0; row < rows; row++)
            //{
            //    for (int col = 0; col < cols; col++)
            //    {
            //        Console.Write(lair[row, col]);
            //    }
            //    Console.WriteLine();
            //}

            var directions = Console.ReadLine();
            for (int j = 0; j < directions.Length; j++)
            {
                
                var command = directions[j];
                if (command == 'U')
                {
                    
                    if (!IsInside(lair, indexPlayerRow - 1, indexPlayerCol))
                    {
                        PlayerWon = true;
                        break;
                    }
                    else
                    {
                        if (lair[indexPlayerRow - 1, indexPlayerCol] == 'B')
                        {
                            IsDead = true;
                            indexPlayerRow -= 1;
                            break;
                        }
                        else
                        {
                            indexPlayerRow -= 1;
                        }
                        
                    }
                    
                }
                else if (command == 'D')
                {
                    
                    if (!IsInside(lair, indexPlayerRow + 1, indexPlayerCol))
                    {
                        PlayerWon = true;
                        break;
                    }
                    else
                    {
                        if (lair[indexPlayerRow + 1, indexPlayerCol] == 'B')
                        {
                            IsDead = true;
                            indexPlayerRow += 1;
                            break;
                        }
                        else
                        {
                            indexPlayerRow += 1;
                        }
                        
                    }
                    
                }
                else if (command == 'R')
                {
                    
                    if (!IsInside(lair, indexPlayerRow, indexPlayerCol + 1))
                    {
                        PlayerWon = true;
                        break;
                    }
                    else
                    {
                        if (lair[indexPlayerRow, indexPlayerCol + 1] == 'B')
                        {
                            IsDead = true;
                            indexPlayerCol += 1;
                            break;
                        }
                        else
                        {
                            indexPlayerCol += 1;
                        }
                        
                    }
                    
                }
                else if (command == 'L')
                {
                    
                    if (!IsInside(lair, indexPlayerRow, indexPlayerCol - 1))
                    {
                        PlayerWon = true;
                        break;
                    }
                    else
                    {
                        if (lair[indexPlayerRow, indexPlayerCol - 1] == 'B')
                        {
                            IsDead = true;
                            indexPlayerCol -= 1;
                            break;
                        }
                        else
                        {
                            indexPlayerCol -= 1;
                        }
                        
                    }
                    
                }

                for (int row = 0; row < lair.GetLength(0); row++)
                {
                    if (IsDead)
                    {
                        break;
                    }
                    for (int col = 0; col < lair.GetLength(1); col++)
                    {
                        if (lair[row, col] == 'B')
                        {
                            if (IsInside(lair, row - 1, col))
                            {
                                if (lair[row - 1, col] == 'P')
                                {
                                    lair[row - 1, col] = 'B';
                                    IsDead = true;
                                    break;
                                }
                                lair[row - 1, col] = 'B';
                            }
                            if (IsInside(lair, row, col - 1))
                            {
                                if (lair[row, col - 1] == 'P')
                                {
                                    lair[row, col - 1] = 'B';
                                    IsDead = true;
                                    break;
                                }
                                lair[row, col - 1] = 'B';
                            }
                            if (IsInside(lair, row, col + 1))
                            {
                                if (lair[row, col + 1] == 'P')
                                {
                                    lair[row, col + 1] = 'B';
                                    IsDead = true;
                                    break;
                                }
                                lair[row, col + 1] = 'B';
                            }
                            if (IsInside(lair, row + 1, col))
                            {
                                if (lair[row + 1, col] == 'P')
                                {
                                    lair[row + 1, col] = 'B';
                                    IsDead = true;
                                    break;
                                }
                                lair[row + 1, col] = 'B';
                            }
                            Array.Copy()
                        }
                    }
                }
            }
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write(lair[row, col]);
                }
                Console.WriteLine();
            }

            if (PlayerWon)
            {
                Console.WriteLine($"won: {indexPlayerRow} {indexPlayerCol}");
            }
            else if (IsDead)
            {
                Console.WriteLine($"dead: {indexPlayerRow} {indexPlayerCol}");
            }
        }
        
        static bool IsInside(char[,] matrix, int row, int col)
        {
            if (0 <= row && row <= matrix.GetLength(0) &&
                0 <= col && col <= matrix.GetLength(0))
            {
                return true;
            }
            return false;
        }
    }
}
