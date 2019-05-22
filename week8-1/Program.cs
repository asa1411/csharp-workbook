using System;
using System.Collections.Generic;
using System.Linq;

namespace week8_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person fred = new Person("fred", 8);
            Person bob = new Person("bob", 12);
            Person maggie = new Person("maggie", 10);
            List<Person> children = new List<Person>();
            children.Add(fred);
            children.Add(bob);
            children.Add(maggie);
            IEnumerable<string> results =//string : what comes out at last
            children //starting point, person(s) come out
            .Where (p=>p.age<10)//person go in, person comes out
            .OrderBy (p =>p.age * p.name.Length) //perosn goies in, person goes out
            .Select(p => p.name); //person goes in, string come out

foreach(String s in results){
    Console.WriteLine(s);
}

        }
    }
    public class Person
    {
        public string name;
        public int age;
        public Person(string initialName, int initialAge)
        {
            this.name = initialName;
            this.age = initialAge;
        }
    }
}
//num => num % 2 == 0     public bool x(int num) {return num % 2 ==0;}
// work as a filter
//List<int> x = {2, 3, 4, 7, 8}
