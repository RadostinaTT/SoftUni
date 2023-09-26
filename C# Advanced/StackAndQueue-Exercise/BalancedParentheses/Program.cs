using System;
using System.Collections.Generic;

namespace BalancedParentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var stack = new Stack<char>();
            var queue = new Queue<char>();
            var result = "";

            if (input.Length % 2 != 0)
            {
                result = "NO";
            }
            else
            {
                result = "YES";
                for (int i = 0; i < input.Length / 2; i++)
                {
                    stack.Push(input[i]);
                }
                for (int j = input.Length / 2; j < input.Length; j++)
                {
                    queue.Enqueue(input[j]);
                }
                while (stack.Count > 0)
                {

                    if (!IsMatch(stack.Pop(), queue.Dequeue()))
                    {
                        result = "NO";
                        break;
                    }
                }
                
            }
            Console.WriteLine(result);
            
        }

        static bool IsMatch(char first, char second)
        {
            if (first == '(' && second == ')')
            {
                return true;
            }
            else if (first == '[' && second == ']')
            {
                return true;
            }
            else if (first == '{' && second == '}')
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
