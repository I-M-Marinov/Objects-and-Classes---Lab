using System;
using System.Collections.Generic;
using System.Linq;

namespace P7.VehicleCatalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            Catalog catalog = new Catalog();

            while ((input = Console.ReadLine()) != "end")
            {
                string[] tokens = input.Split("/");

                string type = tokens[0];
                string brand = tokens[1];
                string model = tokens[2];

                if (type == "Car")
                {
                    catalog.Cars.Add(new Car
                    {
                        Brand = brand,
                        Model = model,
                        HorsePower = int.Parse(tokens[3])
                    });
                }
                else
                {
                    catalog.Trucks.Add(new Truck
                    {
                        Model = model,
                        Brand = brand,
                        Weight = int.Parse(tokens[3])
                    });
                }
            }

            if (catalog.Cars.Count > 0)
            {
                Console.WriteLine("Cars:");

                foreach (Car car in catalog.Cars.OrderBy(x => x.Brand))
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
            }

            if (catalog.Trucks.Count > 0)
            {
                Console.WriteLine("Trucks:");

                catalog.Trucks.OrderBy(x => x.Brand);
                foreach (Truck truck in catalog.Trucks.OrderBy(x => x.Brand))
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }
        }
    }
    public class Catalog
    {
        
        public Catalog()
        {
            Trucks = new List<Truck>();
            Cars = new List<Car>();
        }

        public List<Truck> Trucks { get; set; }

        public List<Car> Cars { get; set; }
    }

    public class Truck
    {
        public string Brand { get; set; }

        public string Model { get; set; }

        public int Weight { get; set; }
    }

    public class Car
    {
        public string Brand { get; set; }

        public string Model { get; set; }

        public int HorsePower { get; set; }
    }
}

