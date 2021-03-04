using System;
using System.Collections.Generic;
using System.Text;

namespace Speed_Racing
{
    class Distance
    {
        string model { get; set; }
        int traveledDistance { get; set; }

        public void isPossible(string model, decimal fuelAmount, decimal fuelConsumption, int travelDistance , List<Car> cars)
        {
            if (fuelConsumption * travelDistance > fuelAmount)
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
            else
            {
                cars.Find(x => x.Model == model).FuelAmount -= fuelConsumption * travelDistance;
                cars.Find(x => x.Model == model).TraveledDistance += travelDistance;
            }


        }
    }
}
