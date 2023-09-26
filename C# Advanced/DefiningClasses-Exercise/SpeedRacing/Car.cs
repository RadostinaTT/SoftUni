using System;
using System.Collections.Generic;
using System.Text;

namespace SpeedRacing
{
    public class Car
    {
        public string model;
        public decimal fuelAmount;
        public decimal fuelConsumptionPerKilometer;
        public decimal travelledDistance = 0;

        public Car(string model, decimal fuelAmount, decimal fuelConsumptionFor1Km)
        {
            this.model = model;
            this.fuelAmount = fuelAmount;
            this.fuelConsumptionPerKilometer = fuelConsumptionFor1Km;
            this.travelledDistance = 0;
        }
        //public string Model { get; set; }
        //public decimal FuelAmount { get; set; }
        //public decimal FuelConsumptionPerKilometer { get; set; }
        //public decimal TravelledDistance { get; set; }

        public void Drive(decimal distanceTraveled)
        {
            //if (this.fuelAmount < distance * this.fuelConsumptionPerKilometer)
            //{
            //    Console.WriteLine("Insufficient fuel for the drive");
            //}
            //else
            //{
            //    this.fuelAmount -= distance * this.fuelConsumptionPerKilometer;
            //    this.travelledDistance += distance;
            //}
            var fuelCost = distanceTraveled * this.fuelConsumptionPerKilometer;
            if (fuelCost <= this.fuelAmount)
            {
                this.fuelAmount -= fuelCost;
                this.travelledDistance += distanceTraveled;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }
    }
}
