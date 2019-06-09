using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
namespace week9_1_framework
{
    public class Dao
    {
        private BooksContext context;
        public Dao()
        {
            context = new BooksContext();
            context.Database.EnsureCreated();
        }
        public void create(String title, Type type)
        {
            Book items = new Book(title, type);
            context.Add(items);
            context.SaveChanges();
        }
        public List<Book> listBooks()
        {
            // return books; This is a real list of books
            List<Book> result = new List<Book>();//this is the copy of a list of real books
            foreach (Book b in context.books)
            {
                result.Add(b);
            }
            return result;
        }
        public List<Book> listFictionBooks()
        {
            List<Book> result = new List<Book>();
            foreach (Book b in context.books)
            {
                if (b.type == Type.Fiction)
                {
                    result.Add(b);
                }
            }
            return result;
        }
    }
    public class BooksContext : DbContext
    {
        public DbSet<Book> books { get; private set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=./books.db");
        }
    }
}