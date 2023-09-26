using System;
using System.Linq;

namespace KnightGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int dimensions = int.Parse(Console.ReadLine());
            var matrix = new char[dimensions, dimensions];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string input = Console.ReadLine();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];
                }
            }
            //for (int row = 0; row < matrix.GetLength(0); row++)
            //{
            //    for (int col = 0; col < matrix.GetLength(1); col++)
            //    {
            //        Console.Write(matrix[row, col]);
            //    }
            //    Console.WriteLine();
            //}
            int fightsStopped = 0;
            //bool IsFight = true;
            int maxKhight = -1;
            int maxKnightRow = -1;
            int maxKnightCol = -1;
            while (true)
            {
                
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        if (matrix[row, col].Equals('K'))
                        {
                            int count = 0;
                            if (IsInside(matrix, row - 2, col + 1) && matrix[row - 2, col + 1] == 'K')
                            {
                                count++;
                            }
                            if (IsInside(matrix, row - 2, col - 1) && matrix[row - 2, col - 1] == 'K')
                            {
                                count++;
                            }
                            if (IsInside(matrix, row - 1, col + 2) && matrix[row - 1, col + 2] == 'K')
                            {
                                count++;
                            }
                            if (IsInside(matrix, row - 1, col - 2) && matrix[row - 1, col - 2] == 'K')
                            {
                                count++;
                            }
                            if (IsInside(matrix, row + 1, col + 2) && matrix[row + 1, col + 2] == 'K')
                            {
                                count++;
                            }
                            if (IsInside(matrix, row + 1, col - 2) && matrix[row + 1, col - 2] == 'K')
                            {
                                count++;
                            }
                            if (IsInside(matrix, row + 2, col + 1) && matrix[row + 2, col + 1] == 'K')
                            {
                                count++;
                            }
                            if (IsInside(matrix, row + 2, col - 1) && matrix[row + 2, col - 1] == 'K')
                            {
                                count++;
                            }
                            if (count > maxKhight)
                            {
                                maxKhight = count;
                                maxKnightRow = row;
                                maxKnightCol = col;

                            }
                            count = 0;
                        }
                        
                    }
                }
                if (maxKhight == 0)
                {
                    //IsFight = false;
                    Console.WriteLine(fightsStopped);
                    return;
                }
                else
                {
                    matrix[maxKnightRow, maxKnightCol] = '0';
                    fightsStopped++;
                    maxKhight = 0;
                }
                

            }
            


        }
        static bool IsInside(char[][] matrix, int row, int col)
        {
            bool check = false;
            if (0 <= row && row < matrix.Length && 0 <= col && col < matrix[row].Length)

            {
                check = true;
            }

            return check;
        }
        static int CountFights(char[,] matrix, int row, int col)
        {
            int count = 0;
            if (IsInside(matrix, row - 2, col + 1) && matrix[row - 2, col + 1] == 'K')
            {
                count++;
            }
            if (IsInside(matrix, row - 2, col - 1) && matrix[row - 2, col - 1] == 'K')
            {
                count++;
            }
            if (IsInside(matrix, row - 1, col + 2) && matrix[row - 1, col + 2] == 'K')
            {
                count++;
            }
            if (IsInside(matrix, row - 1, col - 2) && matrix[row - 1, col - 2] == 'K')
            {
                count++;
            }
            if (IsInside(matrix, row + 1, col + 2) && matrix[row + 1, col + 2] == 'K')
            {
                count++;
            }
            if (IsInside(matrix, row + 1, col - 2) && matrix[row + 1, col - 2] == 'K')
            {
                count++;
            }
            if (IsInside(matrix, row + 2, col + 1) && matrix[row + 2, col + 1] == 'K')
            {
                count++;
            }
            if (IsInside(matrix, row + 2, col - 1) && matrix[row + 2, col - 1] == 'K')
            {
                count++;
            }
            
            

            return count;
        }

    }

    
}
