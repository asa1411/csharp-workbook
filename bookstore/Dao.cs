using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace EF{
    // this class manages the data access to books
    public  class Dao
    {
        private BooksContext context;

        // creates a new instance of the dao
        public Dao()
        {
            context = new BooksContext();
            context.Database.EnsureCreated();

        }
        
        // create the coresponding book and store it
        public void create(String title, Type type)
        {
            Book newBook = new Book(title, type);
            context.books.Add(newBook);
            context.SaveChanges();
        }

        // return the current list of books
        public List<Book> listBooks(){
            List<Book> result  = new List<Book>();
            foreach(Book b in context.books) 
            {
                result.Add(b);
            }
            return result;
        }

        // return only the fiction books
        public  List<Book> listFictionBooks() {
            
            List<Book> result = new List<Book>();
            foreach(Book b in context.books)
            {
                if(b.type == Type.Fiction)
                {
                    result.Add(b);
                }
            }
            return result;
        }
    }

    // using Microsoft.EntityFrameworkCore;

    public class  BooksContext : DbContext
    {
        public DbSet<Book> books { get; private set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=./books.db");

        }
    }

}