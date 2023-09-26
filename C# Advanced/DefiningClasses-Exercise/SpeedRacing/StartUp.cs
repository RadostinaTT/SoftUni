using System;
using System.Linq;
using System.Collections.Generic;

namespace SpeedRacing
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int counter = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < counter; i++)
            {
                var input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                var model = input[0];
                var fuelAmount = decimal.Parse(input[1]);
                var travelledDistance = decimal.Parse(input[2]);
                var car = new Car(model, fuelAmount, travelledDistance);

                cars.Add(car);
            }
            while (true)
            {
                var command = Console.ReadLine();
                if (command == "End")
                {
                    break;
                }
                string[] parts = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string modelCar = parts[1];
                var distanceToDrive = decimal.Parse(parts[2]);
                foreach (var car in cars)
                {
                    if (car.model == modelCar)
                    {
                        car.Drive(distanceToDrive);
                    }
                }

            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TravelledDistance}");
            }
        }
    }
}
