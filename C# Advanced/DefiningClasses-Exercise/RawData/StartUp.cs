using System;
using System.Linq;
using System.Collections.Generic;

namespace RawData
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int countCars = int.Parse(Console.ReadLine());
            Car[] car = new Car[countCars];
            for (int i = 0; i < countCars; i++)
            {
                var input = Console.ReadLine();
                var parts = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = parts[0];
                int engineSpeed = int.Parse(parts[1]);
                int enginePower = int.Parse(parts[2]);
                int cargoWeight = int.Parse(parts[3]);
                string cargoType = parts[4];
                double tire1Pressure = double.Parse(parts[5]);
                int tire1Age = int.Parse(parts[6]);
                double tire2Pressure = double.Parse(parts[7]);
                int tire2Age = int.Parse(parts[8]);
                double tire3Pressure = double.Parse(parts[9]);
                int tire3Age = int.Parse(parts[10]);
                double tire4Pressure = double.Parse(parts[11]);
                int tire4Age = int.Parse(parts[12]);

                car[i] = new Car(model, new Engine(engineSpeed, enginePower), new Cargo(cargoWeight, cargoType), new List<Tyre> { new Tyre(tire1Pressure, tire1Age), new Tyre(tire2Pressure, tire2Age), new Tyre(tire3Pressure, tire3Age), new Tyre(tire4Pressure, tire4Age) });
            }
            var criteria = Console.ReadLine();
            if (criteria == "fragile")
            {
                foreach (var item in car.Where(x => x.cargo.CargoType == "fragile").Where(y => y.tires.Any(t => t.TyrePressure < 1)))
                {
                    Console.WriteLine(item.model);
                }
            }
            else if (criteria == "flamable")
            {
                foreach (var item in car.Where(x => x.cargo.CargoType == "flamable").Where(y => y.engine.EnginePower > 250))
                {
                    Console.WriteLine(item.model);
                }
            }

        }
    }
}
