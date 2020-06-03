﻿using System;

namespace ooppractice
{
    class Program
    {
        public static void Main()
        {
            Person leia = new Person("Leia", "Organa", "Rebel");
            Person darth = new Person("Darth", "Vader", "Imperial");
            Person han = new Person ("Han", "Solo", "Imperial");
            Person luke = new Person("Luke", "Skywalker", "Rebel");
            Ship falcon = new Ship("Rebel", "Smuggling", 2);
            Ship tie = new Ship("Tie", "Fighter", 1);
            Ship x = new Ship("Rebel", "Fighter", 5);
            
            Station space = new Station("Rebel", "OK");
            Station star = new Station("Death", "Never");
            falcon.EnterShip(leia, 1);
            tie.EnterShip(darth, 0);
            falcon.ExitShip(0);
            Console.WriteLine(leia.FullName);
            Console.WriteLine(star.alliance);
            Console.WriteLine(tie.Passengers);


        }
    }

    class Person
    {
        private string firstName;
        private string lastName;
        private string alliance;
        public Person(string firstName, string lastName, string alliance)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.alliance = alliance;
        }

        public string FullName
        {
            get
            {
                return this.firstName + " " + this.lastName;
            }

            /*set
            {
                string[] names = value.Split(' ');
                this.firstName = names[0];
                this.lastName = names[1];
            }*/
        }
    }

    class Ship
    {
        private Person[] passengers;
        public Ship(string alliance, string type, int size)
        {
            this.Type = type;
            this.Alliance = alliance;
            this.passengers = new Person[size];
        }

        public string Type
        {
            get;
            set;
        }

        public string Alliance
        {
            get;
            set;
        }

        public string Passengers
        {
            get
            {
                foreach (var person in passengers)
                {
                    Console.WriteLine(String.Format("{0}", person.FullName));
                }

                return "That's Everybody!";
            }
        }

        public void EnterShip(Person person, int seat)
        {
            this.passengers[seat] = person;
        }

        public void ExitShip(int seat)
        {
            this.passengers[seat] = null;
        }

    }
    class Station
    {
        private Ship [] ships;
        public Station(Ship ship, int capa)
        {
            this.ship;
        }
        public void dockShip(Ship ship)
        {; }
        public void leaveStation()
        { }

    }
}
