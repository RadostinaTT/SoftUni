using System;
using System.Collections.Generic;

namespace Crossroad
{
    class Program
    {
        static void Main(string[] args)
        {
            int greenLight = int.Parse(Console.ReadLine());
            int freeWindow = int.Parse(Console.ReadLine());

            int countPassedCars = 0;
            bool IsCrushed = false;
            string hitCar = "";
            char hitChar = ' ';
            var queue = new Queue<string>();
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "END")
                {
                    break;
                }
                if (command != "green")
                {
                    queue.Enqueue(command);
                }
                else
                {
                    var leftGreen = greenLight;
                    while (leftGreen > 0 && queue.Count > 0)
                    {
                        var passingCar = queue.Dequeue();
                        leftGreen -= passingCar.Length;
                        countPassedCars++;
                        if ((leftGreen + freeWindow) < 0)
                        {
                            IsCrushed = true;
                            hitCar = passingCar;
                            int hitIndex = passingCar.Length + leftGreen + freeWindow;
                            hitChar = passingCar[hitIndex];
                        }
                    }
                    
                    
                }
            }
            if (IsCrushed)
            {
                Console.WriteLine("A crash happened!");
                Console.WriteLine($"{hitCar} was hit at {hitChar}.");
            }
            else
            {
                Console.WriteLine("Everyone is safe.");
                Console.WriteLine($"{countPassedCars} total cars passed the crossroads.");
            }
        }
    }
}
