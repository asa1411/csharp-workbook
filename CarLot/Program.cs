using System;
using System.Collections.Generic;

namespace OOP3
{

    public class Program
    {
        // program driver, has main

        public static void Main(String[] args)
        {
            CarLot jimmiesCars = new CarLot("A");
            CarLot canesCars = new CarLot("B");
            Car mazda = new Car("coupe", 4, 123, "Kia", "Forte", 12000);
            Car bmw = new Car("sedan", 2, 345, "Hyundai", "SUV", 2450.67);
            Truck f150 = new Truck(2, 567, "Benz", "Truck", 43560.34);
            Truck f1674 = new Truck(3, 897, "Toyota", "truck", 34592.3);
            jimmiesCars.Add(mazda);
            jimmiesCars.Add(bmw);
            canesCars.Add(f150);
            canesCars.Add(f1674);
            jimmiesCars.PrintInventory();
            canesCars.PrintInventory();

        }

    }

    public class CarLot
    {
        // represnets a carlot
        public List<Vehicle> inventory = new List<Vehicle>();
        public String name { get; set; }
        public CarLot(string initialName)
        { this.name = initialName; }

        public void Add(Vehicle vehicle)
        {
            // code goes here .
            inventory.Add(vehicle);
        }


        public void PrintInventory()
        {

            foreach (var a in inventory)
            {

                Console.WriteLine("{0}, {1}, {2}, {3}", a.licenseNumber, a.make, a.model, a.price);
            }

            Console.WriteLine("Vehicles of CarLot:, {0}", inventory.Count);
        }

    }

    public abstract class Vehicle
    {
        // parent class that has common attributes of cars and trucks
        public int licenseNumber { get; private set; }
        public string make { get; set; }
        public string model { get; set; }
        public double price { get; set; }
        public Vehicle(int initialLicenseNumber, string initialMake, string initialModel, double initialPrice)
        {
            this.licenseNumber = initialLicenseNumber;
            this.make = initialMake;
            this.model = initialModel;
            this.price = initialPrice;
        }

        override
        public String ToString()
        {
            String s = string.Format("licensenumber: {0}; make: {1}; model: {2}; price: {3}; ", licenseNumber, make, model, price);
            // code goes here
            return s;
        }

    }

    public class Car : Vehicle
    {
        // class that extends vehicle
        public string type { get; set; }
        public int numberOfDoors { get; set; }
        public Car(string initialType, int initialNumberOfDoors, int initialLicenseNumber, string initialMake, string initialModel, double initialPrice) : base(initialLicenseNumber, initialMake, initialModel, initialPrice)
        {
            this.type = initialType;
            this.numberOfDoors = initialNumberOfDoors;
        }
    }

    public class Truck : Vehicle
    {
        // class that extends vehicle 
        public int bedSize { get; set; }
        public Truck(int initialBedSize, int initialLicenseNumber, string initialMake, string initialModel, double initialPrice) : base(initialLicenseNumber, initialMake, initialModel, initialPrice)
        {
            this.bedSize = initialBedSize;
        }
    }
}
