namespace Vehicles.Models
{
    public class Car : Vehicle
    {
        private const double AirConditionAditionConsumption = 0.9;

        public Car(double fuelQuantity, double fuelConsumption, double tankCapacity) 
            : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
            this.FuelConsumption += AirConditionAditionConsumption;
        }

        public override void Refuel(double fuel)
        {
            base.Refuel(fuel);
        }
    }
}