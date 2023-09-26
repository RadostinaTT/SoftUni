using System;
using System.Collections.Generic;
using System.Linq;

namespace SimpleTextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOperations = int.Parse(Console.ReadLine());
            Stack<string[]> stack = new Stack<string[]>();
            for (int i = 0; i < countOperations; i++)
            {
                stack.Push(Console.ReadLine().Split());
            }
            Console.WriteLine(string.Join(',', stack));
            for (int i = 0; i < countOperations; i++)
            {
                string[] currentCommand = stack.Peek();
                if (currentCommand[0] == "4")
                {
                    stack.Pop();
                    stack.Pop();
                }
                else
                {

                    stack.Push(currentCommand[.ToString);
                }
            }
            Console.WriteLine(string.Join(',', stack));

        }
    }
}
