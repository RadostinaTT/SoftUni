namespace NeedForSpeed
{
    using System;
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Vehicle vehicle = new Car(300, 100);
            //var car = new Car(300, 100);

            vehicle.Drive(10);
            //car.Drive(10);

            Console.WriteLine(vehicle.FuelConsumption);
            //Console.WriteLine(car.Fuel);
        }
    }
}
