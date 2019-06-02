using System;
using System.Collections.Generic;
using System.Linq;

namespace toDoApp
{
    class Controller
    {
        public static void homescreen(toDoAppContext _toDo)
        {
            Console.WriteLine("Available functions:");
            Console.WriteLine("add: to add an item");
            Console.WriteLine("delete: to delete an item");
            Console.WriteLine("mark done: the item to mark as done");
            Console.WriteLine("list pending: to list the pending items");
            Console.WriteLine("list done: to list done items");
            Console.WriteLine("list all: to list all items");
            Console.WriteLine("quit: to exit");
            Console.WriteLine("");
            Console.WriteLine("What would you like to do?");
            string input = Console.ReadLine();
            if (input == "add")
            {
                add(_toDo);

            }
            if (input == "list all")
            {
                listAll(_toDo);
            }

        }
        public static void add(toDoAppContext _toDo)
        {
            Console.WriteLine("Enter an item description.");
            string desc1 = Console.ReadLine();
            
            Item myItem = new Item(desc1, Status.pending);
            _toDo.items.Add(myItem);
            _toDo.SaveChanges();

        }
        public static void listAll(toDoAppContext _toDo)
        {
            var result = from s in _toDo.items
                         select s;
            //select * from _toDo.items;
            foreach (Item i in result)
            {
                Console.WriteLine("{0} {1} {2}", i.id, i.desc, i.status);
            }

        }

        static void Main(string[] args)
        {

            Dao dao = new Dao();
            toDoAppContext _toDo = new toDoAppContext();

            Controller.homescreen(_toDo);

            foreach (Item i in dao.listItems())
            {
                Console.WriteLine(" ");
            }
        }
    }
}