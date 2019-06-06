using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace toDoApp
{
    public class Dao
    {
        private toDoAppContext context;

        // creates a new instance of the dao
        public Dao()
        {
            context = new toDoAppContext();
            context.Database.EnsureCreated();

        }

        // create the coresponding item and store it
        public void create(String desc)
        {
            Item newItem = new Item(desc, false);
            context.items.Add(newItem);
            context.SaveChanges();
        }

        // return the current list of item descriptions
        public void listItems()
        {
            string status;
            foreach (Item i in context.items)
            {
                if (i.done == false)
                {
                    status = "pending";
                    Console.WriteLine("{0} {1} {2}", i.id, i.desc, status);

                }
                if (i.done == true)
                {
                    status = "done";
                    Console.WriteLine("{0} {1} {2}", i.id, i.desc, status);
                }

            }

        }

        public void markDone(int id)
        {
            foreach (Item i in context.items)
            {
                if (id == i.id)
                {
                    i.done = true;
                    context.SaveChanges();
                }

            }
        }

        public void delete(int id)
        {
            foreach (Item i in context.items)
            {
                if (id == i.id)
                {
                    context.items.Remove(i);
                    context.SaveChanges();
                }
            }
        }

        // return only the done item descriptions
        public List<Item> listDoneItems()
        {

            List<Item> result = new List<Item>();
            foreach (Item i in context.items)
            {
                if (i.done == true)
                {
                    result.Add(i);
                }
            }
            return result;
        }
        public List<Item> listPendingItems()
        {
            List<Item> result = new List<Item>();
            foreach (Item i in context.items)
            {
                if (i.done == false)
                { result.Add(i); }

            }
            return result;
        }
    }

    // using Microsoft.EntityFrameworkCore;

    public class toDoAppContext : DbContext
    {
        public DbSet<Item> items { get; private set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=./items2.db");

        }
    }

}