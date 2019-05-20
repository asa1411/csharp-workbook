using System;

namespace IRentable
{
    class Program
    {
        static void Main(string[] args)
        {

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
        override
        public string ToString()
        {
            string s = string.Format("{0} {1}", this.name, this.hourlyRate);
            return s;
        }
        public double getDailyRate()
        {
            return hourlyRate * 24;
        }
        public string getDescriptor()
        {
            return "";
        }
    }
    class House : IRentable
    {

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
        {
            return this.dailyRate;
        }
        public string getDescriptor()
        {
            return "";
        }
    }


}
