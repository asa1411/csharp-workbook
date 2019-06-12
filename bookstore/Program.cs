using System;
using System.Collections.Generic;

namespace EF
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Dao dao = new Dao();
            dao.create("Cat in the Hat", Type.Kids);
            dao.create("The Hobbit", Type.Fiction);
            
            foreach(Book b in dao.listBooks())
            {
                Console.WriteLine(b.title+" is a "+b.type+" book");
            }
            Console.WriteLine("Enter a title of a book");
            string title = Console.ReadLine();
            Console.WriteLine("Enter the type of the book: Biography, Fiction or Kids");
            string type = Console.ReadLine().ToLower();
            if(type=="biography")
            {dao.create(title, Type.Biography);}
            else if(type=="fiction")
            {dao.create(title, Type.Fiction);}
            else if(type=="kids")
            {dao.create(title, Type.Kids);}

        }
    }
    
}
