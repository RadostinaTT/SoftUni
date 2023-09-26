using System;
using System.Linq;
using System.Collections.Generic;

namespace ListyIterator
{
    public class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            List<string> create = command.Split().Skip(1).ToList();
            ListyIterator<List<string>> listyIterator = new ListyIterator<List<string>>(create);
            
            while (command != "END")
            {
                if (command == "Print")
                {
                    try
                    {
                        listyIterator.Print();
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                else if (command == "Move")
                {
                    bool result = listyIterator.Move();
                    Console.WriteLine(result);
                }
                else if (command == "HasNext")
                {
                    bool result = listyIterator.HasNext();
                    Console.WriteLine(result);
                }
            }
        }
    }
}
