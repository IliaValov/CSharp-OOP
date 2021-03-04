using System;
using System.Collections.Generic;
using System.Text;


namespace StorageMaster.Core
{
    using StorageMaster.Controler;
    using System.Linq;

    public class Engine
    {

        private StorageMaster storageMaster;
        public Engine()
        {
            storageMaster = new StorageMaster();
        }

        public void Run()
        {
            string[] input = Console.ReadLine().Split();

            while (input[0] != "END")
            {
                try
                {

                    string command = input[0];
                    switch (command)
                    {
                        case "AddProduct":
                            string type = input[1];
                            double price = double.Parse(input[2]);
                            Console.WriteLine(storageMaster.AddProduct(type, price));
                            break;
                        case "RegisterStorage":
                            type = input[1];
                            string name = input[2];
                            Console.WriteLine(storageMaster.RegisterStorage(type, name));

                            break;
                        case "SelectVehicle":
                            string storageName = input[1];
                            int garageSlot = int.Parse(input[2]);
                            Console.WriteLine(storageMaster.SelectVehicle(storageName, garageSlot));

                            break;
                        case "LoadVehicle":

                            Console.WriteLine(storageMaster.LoadVehicle(input.Skip(1)));
                            break;
                        case "SendVehicleTo":
                            string sourceName = input[1];
                            int sourceGarageSlot = int.Parse(input[2]);
                            string destinationName = input[3];
                            Console.WriteLine(storageMaster.SendVehicleTo(sourceName, sourceGarageSlot, destinationName));

                            break;
                        case "UnloadVehicle":
                            storageName = input[1];
                            garageSlot = int.Parse(input[2]);
                            Console.WriteLine(storageMaster.UnloadVehicle(storageName, garageSlot));

                            break;
                        case "GetStorageStatus":
                            storageName = input[1];
                            Console.WriteLine(storageMaster.GetStorageStatus(storageName));
                            break;
                    }

                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
                input = Console.ReadLine().Split();
            }
            Console.WriteLine(storageMaster.GetSummary());

        }
    }
}
