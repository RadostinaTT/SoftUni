using System;
using System.Collections.Generic;

namespace CarSalesman
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int countEngines = int.Parse(Console.ReadLine());
            List<Engine> engines = new List<Engine>();

            for (int i = 0; i < countEngines; i++)
            {
                var input = Console.ReadLine();
                var parts = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                var model = parts[0];
                var power = parts[1];
                if (parts.Length == 2)
                {
                    engines.Add(new Engine(model, power));
                }
                else if (parts.Length == 3)
                {
                    int displacement;
                    bool IsDisplacement = int.TryParse(parts[2], out displacement);
                    if (IsDisplacement)
                    {
                        engines.Add(new Engine(model, power, displacement));
                    }
                    else
                    {
                        string efficiency = parts[2];
                        engines.Add(new Engine(model, power, efficiency));
                    }
                }
                else if (parts.Length == 4)
                {
                    int displacement = int.Parse(parts[2]);
                    string efficiency = parts[3];
                    engines.Add(new Engine(model, power, displacement, efficiency));
                }
                
                
            }
            int countCars = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < countCars; i++)
            {
                var input = Console.ReadLine();
                var parts = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                var model = parts[0];
                var engineModel = parts[1];
                Engine engine = new Engine(null, null);

                foreach (Engine engineList in engines)
                {
                    if (engineList.Model == engineModel)
                    {
                        engine = engineList;
                    }
                }

                if (parts.Length == 2)
                {
                    cars.Add(new Car(model, engine));
                }
                else if (parts.Length == 3)
                {
                    int weight;
                    bool IsWeight = int.TryParse(parts[2], out weight);
                    if (IsWeight)
                    {
                        weight = int.Parse(parts[2]);
                        cars.Add(new Car(model, engine, weight));
                    }
                    else
                    {
                        string color = parts[2];
                        cars.Add(new Car(model, engine, color));
                    }
                }
                else if (parts.Length == 4)
                {
                    int weight = int.Parse(parts[2]);
                    string color = parts[3];
                    cars.Add(new Car(model, engine, weight, color));
                }
                
            }

            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }
        }
    }
}
