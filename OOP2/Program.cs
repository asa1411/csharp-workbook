﻿using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            car c1 = new car("Black", "VW", "Jetta");
            Console.WriteLine("c1={0}", c1.ToString());//c1 is an instance and nonstatic class makes it possible. 
            car c2 = new car("Blue", "Mazda", "3");
             Console.WriteLine("c2={0}", c2.ToString());
             ParkingGarage p1=new ParkingGarage(7);
             //to put car1 to the parking garage
             p1.parkingSlots[1] = c1;//parkingSlots are private so it can not take it
             p1.parkCar(c1, 1);//pass in the car you are parking, and the postion to park it in
             //parkCar is nonstatic method because it takes instances
             Console.WriteLine("is slot 1 empty? {0}", p1.isSlotAvailable(1));
             p1.parkCar(c1,1);
             p1.towCar(1);
             //All the above was deleted
             ParkingGarage parkingGarage = null;
             while(parkingGarage ==null) {
                 try{
                     Console.WriteLine("Enter the size of garage");
                     String userinput = Console.ReadLine
                 }
             } 
        }
    }
    //represent a car as a class.
    //represent a parking garage as a class
    //we want to use our parking garage class, to manage our inventory.
    public class car
    {
    public string make{get; private set;}
    public string model;
    public string color;
    public int year;
public car (String initialColor, string initialMake, string initialModel)
{
    this.color = initialColor;
    this.make = initialMake;
    this.model = initialModel;
}
    }
    public String ToString()
    {
String stringRepresentation = 
String.Format("{0} {1} {2}", this.color, this.make, this.model);
return stringRepresentation;
    }
    public class ParkingGarage
    {
        public int numSpaces{get; private set;}
        private car[] parkingSlots;
        public ParkingGarage(int desiredNumberOfSlots)
        {
            parkingSlots = new car[desiredNumberOfSlots];
        }
//this method should return true, if the slot is available
//otherwise should return false
public bool isSlotAvailable(int slotNumber){
    car the CarInTheSlot = parkingSlots[slotNumber];
    if(theCarInTheSlot ==null)
    {
        return true;
    }
    else{
        return false;
    }
}
public void parkCar (car theCar, int theSlot ){
    //so needed by this following 
    bool isSlotEmpty = isSlotAvailable(theSlot);
    if ((isSlotEmpty)==true)
    {
        this.parkingSlots[theSlot]=theCar;//it may overwrite by two cars
    }
    //bad parking garage did not actually park my car....
    else{
        throw new Exception("Slot " + theSlot+" is taken");
    }
}
public car towCar(int theSlot)
{
    car c = parkingSlots[theSlot];
    parkingSlots[theSlot]=null;
    return c;//whatever or wherever is called on, it will execute this return
}

    }
}
