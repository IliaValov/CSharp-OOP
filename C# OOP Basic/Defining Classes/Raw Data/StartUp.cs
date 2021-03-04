using System;
using System.Collections.Generic;

namespace Raw_Data
{
    class StartUp
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                List<Tires> tires = new List<Tires>();

                string[] parrametars = Console.ReadLine().Split();

                string model = parrametars[0];

                int engineSpeed = int.Parse(parrametars[1]);
                int enginePower = int.Parse(parrametars[2]);

                int cargoWeight = int.Parse(parrametars[3]);
                string cargoType = parrametars[4];

                for (int j = 0; j < 8; j += 2)
                {
                    decimal tirePresure = decimal.Parse(parrametars[5 + j]);
                    int tireAge = int.Parse(parrametars[6 + j]);

                    Tires tire = new Tires(tirePresure, tireAge);
                    tires.Add(tire);
                }
                Engine engine = new Engine(engineSpeed, enginePower);

                Cargo cargo = new Cargo(cargoType, cargoWeight);

                Car car = new Car(model, engine, cargo, tires);

                cars.Add(car);
            }
            string input = Console.ReadLine();


            if (input == "fragile")
            {
                Fragile(cars);
            }
            else
            {
                Flamable(cars);
            }
        }

        private static void Flamable(List<Car> cars)
        {
            foreach (var item in cars)
            {
                if (item.Cargo.CargoType == "flamable")
                {
                    if (item.Engine.EnginePower > 250)
                    {
                        Console.WriteLine(item.Model);
                    }
                }
            }
        }

        private static void Fragile(List<Car> cars)
        {
            foreach (var item in cars)
            {

                if (item.Cargo.CargoType == "fragile")
                {
                    foreach (var innerItem in item.Tires)
                    {
                        if (innerItem.TirePresure < 1)
                        {
                            Console.WriteLine(item.Model);
                            break;
                        }
                    }
                }
            }
        }
    }
}
