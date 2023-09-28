namespace Vehicles.Models
{
    public class Bus : Vehicle
    {
        private double airConditionAditionConsumption = 1.4;
        private double defaultFuelConsumption;
        public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity) 
            : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
            this.defaultFuelConsumption = fuelConsumption;
            this.airConditionAditionConsumption += fuelConsumption;
        }

        public bool IsEmpty { get; set; }
        public override bool Drive(double distance)
        {
            if (!IsEmpty)
            {
                this.FuelConsumption = this.airConditionAditionConsumption;
            }
            else
            {
                this.FuelConsumption = this.defaultFuelConsumption;
            }
            return base.Drive(distance);
        }
    }
}