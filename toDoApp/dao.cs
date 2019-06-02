using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace toDoApp
{
    public  class Dao
    {
        private toDoAppContext context;

        // creates a new instance of the dao
        public Dao()
        {
            context = new toDoAppContext();
            context.Database.EnsureCreated();

        }
        
        // create the coresponding item and store it
        public void create(String desc, Status done)
        {
            Item newItem = new Item(desc, done);
            context.items.Add(newItem);
            context.SaveChanges();
        }

        // return the current list of item descriptions
        public List<Item> listItems(){
            List<Item> result  = new List<Item>();
            foreach(Item i in context.items) 
            {
                result.Add(i);
            }
            return result;
        }

        // return only the done item descriptions
        public  List<Item> listDoneItems() {
            
            List<Item> result = new List<Item>();
            foreach(Item i in context.items)
            {
                if(i.status == Status.done)
                {
                    result.Add(i);
                }
            }
            return result;
        }
    }

    // using Microsoft.EntityFrameworkCore;

    public class  toDoAppContext : DbContext
    {
        public DbSet<Item> items { get; private set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=./items.db");

        }
    }

}