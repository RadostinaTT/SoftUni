

namespace Generics_Exercise
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            Box<double> box = new Box<double>();

            int counter = int.Parse(Console.ReadLine());
            for (int i = 0; i < counter; i++)
            {
                double input = double.Parse(Console.ReadLine());
                box.Value.Add(input);
            }

            double command = double.Parse(Console.ReadLine());

            var result = box.GreaterValuesThan(command);
            //int[] command = Console.ReadLine().Split().Select(int.Parse).ToArray();
            //int firstIndex = command[0];
            //int secondIndex = command[1];
            //box.Swap(firstIndex, secondIndex);

            Console.WriteLine(result);


            
        }
    }
}
