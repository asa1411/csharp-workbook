using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace week9_2
{
    class Program
    {
        public static void Main(string[] args)
        {
            Person hank = new Person();

            hank.dad = null;
            hank.mom = null;
            hank.name = "Hank Hill";
            hank.gender = 2;

            Person peggy = new Person();
            peggy.dad = null;
            peggy.mom = null;
            peggy.name = "Peggy Hill";

            Person bobby = new Person();
            bobby.dad = hank;
            bobby.mom = peggy;
            bobby.name = "Bobby Hill";

            Console.WriteLine(hank);
            Console.WriteLine(bobby.dad);
            Console.WriteLine(bobby.mom);
            Console.WriteLine(hank.gender);

            PersonContext context = new PersonContext();
            context.Database.EnsureCreated();
            context.persons.Add(hank);
            context.SaveChanges();

            context.persons.Add(peggy);
            context.SaveChanges();
            context.persons.Add(bobby);
            context.SaveChanges();
            // context.persons.Add(2);
            context.SaveChanges();


        }
    }
    public enum Gender
    {
        male, female
    };
    public class Person
    {
        public int id { get; private set; }
        public string name { get; set; }
        public int momId { get; set; }
        public int gender { get; set; }
        public Person mom { get; set; }
        public int dadId { get; set; }
        public Person dad { get; set; }
        public List<Person> siblings;
        // public Gender gender;//not enum b
        public Person()
        { }
        override public String ToString()
        {
            return String.Format("{0}", this.name);

        }
    }


    public class PersonContext : DbContext
    {
        public DbSet<Person> persons { get; private set; }//this is the database
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=./family.db");
        }
    }
}
