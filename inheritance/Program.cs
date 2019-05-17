using System;
using System.Collections.Generic;

namespace inheritance
{
    class Program
    {
        static void Main(string[] args)
        {//make a list of cars
            Car bigBlue = new Car("Big Blue", 102.40);
            Car herby = new Car("Herby", 40);
            Car delorian = new Car("Delorian", 88);
            Car mysteryMachine = new Car("Mystery Machine", 102.5);

            List<IRace> racers = new List<IRace>();
            racers.Add(bigBlue);
            racers.Add(herby);
            racers.Add(delorian);
            racers.Add(mysteryMachine);

            foreach (IRace r1 in racers)
            {
                foreach (IRace r2 in racers)
                {
                    IRace winner = race(r1, r2);
                    Console.WriteLine("{0} vs {1} = {2}", r1, r2, winner);
                }
            }
        }
        public static IRace race(IRace r1, IRace r2)
        {
            if (r1.speedMPH > r2.speedMPH)
            {
                return r1;
            }
            else
            {
                return r2;
            }
        }
    }
    //interface implementation
    public interface IRace
    {
        double getSpeedMPH();
        //how to use getCelebrateMessage method 
        // string getCelebrateMessage();
    }
    class Car : IRace
    {
        public string name { get; set; }
        public double speedMPH;
        public Car(string initialName, double initialSpeed)
        {
            this.name = initialName;
            this.speedMPH = initialSpeed;
        }
        override
        public String ToString()
        {
            String s = String.Format($"{this.name} {this.speedMPH}");
            return s;
        }
        //needs this for interface
        public double getSpeedMPH()
        {
            return this.speedMPH;
        }
        //here you go
        public string getCelebrateMessage()
        {
            return string.Format("My name is {0},  I am the greatest", this.name);
        }
        //you extend one class, but implements many interfaces
    }

    public class Person : IRace
    {
        public String name { get; private set; }
        public double speedMPM { get; private set; }
        public Person(String initialName, double initialSpeed)
        {
            this.name = initialName;
            this.speedMPM = initialSpeed;
        }
        override
        public String ToString()
        {
            return this.name;
        }
        public double getSpeedMPH()
        {
            return (speedMPM / 60) * 1609;
        }
    }
}
//1 interface
//3 classes + your program class (driver)
//internal store price per unit of time differently for each class
//but you interface should have a single pricePerDay() method, that is used to print your inventory
//gira, sprints, hansoft ---agile method/strategy
