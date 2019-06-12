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
            // add vehicles to inventory list .
            inventory.Add(vehicle);
        }


        public void PrintInventory()
        {
            //For each carlot, print all the components, i.e., license number, make, model, price  in it.
            //for Cars, print type and number of doors in addition to them.
            //for trucks, print size of bed in addition to them.
            //Lastly, print number of vehicles in each car lot.
            foreach (var a in inventory)
            {

                Console.WriteLine("License Number: {0}, Make: {1}, Model: {2}, Price: {3}", a.licenseNumber, a.make, a.model, a.price);

                Console.WriteLine(a.ToString());
            }


            Console.WriteLine("Vehicles of CarLot {0} :  {1}",name, inventory.Count);
        }

    }

    public abstract class Vehicle
    {
        // parent class that has common attributes of cars and trucks
        public int licenseNumber { get; private set; }
        public string make { get; set; }
        public string model { get; set; }
        public double price { get; set; }
        //instantiate four components
        public Vehicle(int initialLicenseNumber, string initialMake, string initialModel, double initialPrice)
        {
            this.licenseNumber = initialLicenseNumber;
            this.make = initialMake;
            this.model = initialModel;
            this.price = initialPrice;
        }
    }

    public class Car : Vehicle
    {
        // class that extends base class vehicle to child class or subclass car. 
        public string type { get; set; }
        public int numberOfDoors { get; set; }
        public Car(string initialType, int initialNumberOfDoors, int initialLicenseNumber, string initialMake, string initialModel, double initialPrice) : base(initialLicenseNumber, initialMake, initialModel, initialPrice)
        {
            this.type = initialType;
            this.numberOfDoors = initialNumberOfDoors;
        }
        //print two more components of car in addition to base class components
        override
         public string ToString()
        {
            string s = string.Format("type of car: {0}, number of door: {1}", type, numberOfDoors);
            return s;
        }
    }

    public class Truck : Vehicle
    {
        // class that extends vehicle to subclass truck
        public int bedSize { get; set; }
        public Truck(int initialBedSize, int initialLicenseNumber, string initialMake, string initialModel, double initialPrice) : base(initialLicenseNumber, initialMake, initialModel, initialPrice)
        {
            this.bedSize = initialBedSize;
        }
        //include this component in printout 
        override
        public string ToString()
        {
            string s = string.Format("bed size of the truck: {0}", bedSize);
            return s;
        }
    }
}
