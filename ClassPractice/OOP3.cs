using System;
using System.Collections.Generic;

namespace OOP3
{
public class Program {
public static void Main (String[] args)
{
    CarLot jimmiesCars = new CarLot("Jimmys Cars");
    Car mazda = new Car();
    Car bmw = new Car();
    Truck f150 = new Truck();
    jimmiesCars.Add(mazda);
    jimmiesCars.Add(bmw);
    
}
}

public class CarLot {
List<Vehicle> inventory;
string names;
public void Add(Vehicle vehicle){

}
public void PrintInventory(){

}
}
public abstract class Vehicle
{//parent class that has common attributes of cars and trucks
override
public String ToString(){
    //code goes here
}

}
public class Vehicle {

}

public class Car: Vehicle {
//
}

public class Truck: Vehicle{
    //class that extends vehicle
}
}