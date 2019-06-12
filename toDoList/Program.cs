using System;
using System.Collections.Generic;

namespace toDoList
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Dao dao = new Dao();
            // dao.create("Cat in the Hat", Type.Kids);
            // dao.create("The Hobbit", Type.Fiction);
            Console.WriteLine ("Enter the title of a book.");
            string title = Console.ReadLine();
            Console.WriteLine ("What is the type of the book? biography, fiction, or kids");
            string type = Console.ReadLine();
            
            foreach(Book b in dao.listBooks())
            {
                Console.WriteLine(b.title+" is a "+b.type+" book");
            }
        }
    }
    
}
