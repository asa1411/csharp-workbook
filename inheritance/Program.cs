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

            List<Car> cars = new List<Car>();
            cars.Add(bigBlue);
            cars.Add(herby);
            cars.Add(delorian);
            cars.Add(mysteryMachine);

            foreach (Car c1 in cars)
            {
                foreach (Car c2 in cars)
                {
                    Car winner = race(c1, c2);
                    Console.WriteLine("{0} vs {1} = {2}", c1, c2, winner);
                }
            }
        }
        public static Car race(Car c1, Car c2)
        {
            if (c1.speedMPH > c2.speedMPH)
            {
                return c1;
            }
            else
            {
                return c2;
            }
        }
    }
    class Car
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

    }
}
