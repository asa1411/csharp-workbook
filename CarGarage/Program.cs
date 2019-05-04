using System;

public class Program
{
    public static void Main()
    {
        Car greenCar = new Car("green");
        Car blueCar = new Car("blue");
        Car redCar = new Car("red");
        Garage smallGarage = new Garage(3);


        smallGarage.ParkCar(blueCar, 0);
        smallGarage.ParkCar(greenCar, 1);
        smallGarage.ParkCar(redCar, 2);
        Console.WriteLine(smallGarage.Cars);
        Person p = new Person("James");

        Person p1 = new Person("John");
        greenCar.enterCar(p1);
        redCar.enterCar(p);
        Console.WriteLine("A Passenger {0} rides in a green car.", p1);
        Console.WriteLine("A Passenger {0} rides in a red car.", p);

    }
}

class Car
{
    public string Color { get; private set; }
    public Person[] passenger;
    public Car(string initialColor)
    {
        Color = initialColor;
        this.passenger = new Person[4];
    }
    public void enterCar(Person p)
    {
        passenger[0] = p;
    }



}

class Garage
{
    private Car[] cars;

    public Garage(int initialSize)
    {
        Size = initialSize;
        this.cars = new Car[initialSize];
    }

    public int Size { get; private set; }

    public void ParkCar(Car car, int spot)
    {
        cars[spot] = car;
    }

    public string Cars
    {
        get
        {
            for (int i = 0; i < cars.Length; i++)
            {
                if (cars[i] != null)
                {
                    Console.WriteLine(String.Format("The {0} car is in spot {1}.", cars[i].Color, i));
                }
            }
            return "That's all!";
        }
    }

}
public class Person

{
    public string Names;

    public Person(string initialName)
    {

        this.Names = initialName;
    }
    override
    public string ToString()
    {
        string s = string.Format("{0}", this.Names);
        return s;
    }
}