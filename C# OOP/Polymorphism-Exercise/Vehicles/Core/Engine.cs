namespace Vehicles.Core
{
    using System;
    using System.Linq;

    using Models;

    class Engine
    {
        public void Run()
        {
            string[] carInfo = Console.ReadLine()
                .Split()
                .ToArray();

            double carFuelQuantity = double.Parse(carInfo[1]);
            double carFuelConsumption = double.Parse(carInfo[2]);
            double carTankCapacity = double.Parse(carInfo[3]);

            string[] truckInfo = Console.ReadLine()
                .Split()
                .ToArray();
 
            double truckFuelQuantity = double.Parse(truckInfo[1]);
            double truckFuelConsumption = double.Parse(truckInfo[2]);
            double truckTankCapacity = double.Parse(truckInfo[3]);

            string[] busInfo = Console.ReadLine()
                .Split()
                .ToArray();

            double busFuelQuantity = double.Parse(busInfo[1]);
            double busFuelConsumption = double.Parse(busInfo[2]);
            double busTankCapacity = double.Parse(busInfo[3]);

            var car = new Car(carFuelQuantity, carFuelConsumption, carTankCapacity);
            var truck = new Truck(truckFuelQuantity, truckFuelConsumption, truckTankCapacity);
            var bus = new Bus(busFuelQuantity, busFuelConsumption, busTankCapacity);

            int countCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < countCommands; i++)
            {
                try
                {
                    string[] inputInfo = Console.ReadLine()
                        .Split()
                        .ToArray();
                    string command = inputInfo[0];
                    string typeVehicle = inputInfo[1];
                    double value = double.Parse(inputInfo[2]);
                    switch (command)
                    {
                        case "Drive":
                            switch (typeVehicle)
                            {
                                case "Car":
                                    DriveVehicle(car, value);
                                    break;
                                case "Truck":
                                    DriveVehicle(truck, value);
                                    break;
                                case "Bus":
                                    bus.IsEmpty = false;
                                    DriveVehicle(bus, value);
                                    break;
                                default:
                                    break;
                            }
                            break;
                        case "Refuel":
                            switch (typeVehicle)
                            {
                                case "Car":
                                    car.Refuel(value);
                                    break;
                                case "Truck":
                                    truck.Refuel(value);
                                    break;
                                case "Bus":
                                    bus.Refuel(value);
                                    break;
                                default:
                                    break;
                            }
                            break;
                        case "DriveEmpty":
                            bus.IsEmpty = true;
                            DriveVehicle(bus, value);
                            break;
                        default:
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            Console.WriteLine($"Car: {car.FuelQuantity:f2}");
            Console.WriteLine($"Truck: {truck.FuelQuantity:f2}");
            Console.WriteLine($"Bus: {bus.FuelQuantity:f2}");
        }

        public static void DriveVehicle(Vehicle vehicle, double value)
        {
            bool canTravell = vehicle.Drive(value);

            string result = !canTravell
                ? $"{vehicle.GetType().Name} needs refueling"
                : $"{vehicle.GetType().Name} travelled {value} km";

            Console.WriteLine(result);
        }
    }
}