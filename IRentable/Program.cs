using System;
using System.Collections.Generic;

namespace IRentable
{
    class Program
    {
        static void Main(string[] args)
        {//instantiate cars, houses and boats
            Car c1 = new Car("c1", 250);
            Car c2 = new Car("c2", 108.9);
            House h1 = new House("h1", 350);
            House h2 = new House("h2", 568.9);
            Boat b1 = new Boat("b1", 25);
            Boat b2 = new Boat("b2", 59.3);
            //make a list of rentables and add them to the list
            List<IRentable> IRent = new List<IRentable>();
            IRent.Add(c1);
            IRent.Add(c2);
            IRent.Add(h1);
            IRent.Add(h2);
            IRent.Add(b1);
            IRent.Add(b2);
            foreach (IRentable a in IRent)
            {//for each rentable, describe it and get its daily rate
                a.getDescriptor();
                a.getDailyRate();
            }

        }
    }
    public interface IRentable
    {
        double getDailyRate();
        string getDescriptor();
    }
    class Boat : IRentable
    {
        public string name { get; set; }
        public double hourlyRate { get; set; }
        public Boat(string initialName, double initialHourlyRate)
        {
            this.name = initialName;
            this.hourlyRate = initialHourlyRate;
        }
        //set variables for printout
        override
        public string ToString()
        {
            string s = string.Format(" {0} {1}", this.name, this.hourlyRate);
            return s;
        }
        public double getDailyRate()
        {//print the daily rate of boats
            Console.WriteLine("${0} per day", hourlyRate * 24);
            return hourlyRate * 24;
        }
        public string getDescriptor()
        {//describe boat and its hourly rate
            Console.WriteLine("Boat {0}, hourly rate: ${1}", this.name, this.hourlyRate);
            return "";
        }
    }
    class House : IRentable
    {
        public string name { get; set; }
        public double weeklyRate { get; set; }
        public House(string initialName, double initialWeeklyRate)
        {
            this.name = initialName;
            this.weeklyRate = initialWeeklyRate;
        }
        override
        public string ToString()
        {
            string s = string.Format("{0} {1}", this.name, this.weeklyRate);
            return s;
        }
        public double getDailyRate()
        {//print daily rate of reting a house
            Console.WriteLine("${0} per day", weeklyRate / 7);
            return weeklyRate / 7;
        }
        public string getDescriptor()
        {//describe house and its weekly rate
            Console.WriteLine("House {0} Weekly Rate: ${1}", this.name, this.weeklyRate);
            return "";
        }
    }
    class Car : IRentable
    {
        public string name { get; set; }
        public double dailyRate { get; set; }
        public Car(string initialName, double initialDailyRate)
        {
            this.name = initialName;
            this.dailyRate = initialDailyRate;
        }
        override
        public string ToString()
        {
            string s = string.Format("{0} {1}", this.name, this.dailyRate);
            return s;
        }
        public double getDailyRate()
        {//get a daily rate for renting a car
            Console.WriteLine("${0} per day", dailyRate);
            return this.dailyRate;
        }
        public string getDescriptor()
        {
            Console.WriteLine("Car {0}, Daily Rate ${1}", this.name, this.dailyRate);
            return "";
        }
    }


}
