using System;
using System.Collections.Generic;

namespace week9_1_framework
{
    class Program
    {
        static void Main(string[] args)
        {
        Dao dao = new Dao();
        //instead of hardcoding a book and type.
        //ask the user for a single title, and a type,
        //and use the dao to create the book.
        //then print all the books

      
        foreach (Book b in dao.listBooks())
        {
            Console.WriteLine(b.title+" is a" + b.type+" book");
        }
        }
    }
    
}

