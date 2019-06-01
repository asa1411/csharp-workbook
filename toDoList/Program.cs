using System;
using System.Collections.Generic;

namespace toDoList
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
        }
    }
    
}
