using System;
using System.Collections.Generic;
using System.Text;

namespace Speed_Racing
{
    public class Car
    {
        //model, fuel amount, fuel consumption for 1 kilometer and  traveled distance
        private string model;
        private decimal fuelAmount;
        private decimal fuelConsumption;
        private int traveledDistance;

        public Car(string model, decimal fuelAmount, decimal fuelConsumption)
        {
            this.model = model;
            this.fuelAmount = fuelAmount;
            this.fuelConsumption = fuelConsumption;
        }

        public int TraveledDistance
        {
            get { return this.traveledDistance; }
            set { this.traveledDistance = value; }
        }

        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }

        public decimal FuelAmount
        {
            get { return this.fuelAmount; }
            set { this.fuelAmount = value; }
        }

        public decimal FuelConsumption
        {
            get { return this.fuelConsumption; }
            set { this.fuelConsumption = value; }
        }
    }
}
