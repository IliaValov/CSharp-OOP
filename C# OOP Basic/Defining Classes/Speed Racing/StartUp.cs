using System;
using System.Collections.Generic;

namespace Speed_Racing
{
    class StartUp
    {
        public static List<Car> cars = new List<Car>();
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input1 = Console.ReadLine().Split();
                string model = input1[0];
                decimal fuelAmount = decimal.Parse(input1[1]);
                decimal fuelConsuption = decimal.Parse(input1[2]);

                Car car = new Car(model, fuelAmount, fuelConsuption);
                cars.Add(car);
            }
            string[] input = Console.ReadLine().Split();

            while (input[0] != "End")
            {
                foreach (var item in cars)
                {
                    if (item.Model == input[1])
                    {
                        Distance distance = new Distance();
                        distance.isPossible(item.Model, item.FuelAmount, item.FuelConsumption, int.Parse(input[2]), cars);
                    }
                }


                input = Console.ReadLine().Split();
            }

            foreach (var item in cars)
            {
                Console.WriteLine($"{item.Model} {item.FuelAmount:F2} {item.TraveledDistance}");
            }
        }
    }
}
