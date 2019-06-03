using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;


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
            if (input == "mark done")
            {
                markDone(_toDo);
            }
            if (input == "delete")
            {
                delete(_toDo);
            }
        }
        public static void add(toDoAppContext _toDo)
        {
            Console.WriteLine("Enter an item description.");
            string desc1 = Console.ReadLine();

            Item myItem = new Item(desc1, Status.pending);
            _toDo.items.Add(myItem);
            _toDo.SaveChanges();
            Console.WriteLine("[item added]");

        }
        public static void listAll(toDoAppContext _toDo)
        {
            var result = from s in _toDo.items
                         select s;
            foreach (Item i in result)
            {
                Console.WriteLine("{0} {1} {2}", i.id, i.desc, i.status);
            }

        }
        public static void markDone(toDoAppContext _toDo)
        {
            Console.WriteLine("Enter the item id.");
            int id2 = Convert.ToInt32(Console.ReadLine());
            Item a = _toDo.items.Find(id2);//find the item of id i from Dbset items in context
            a.status = Status.done;
            _toDo.SaveChanges();
            Thread.Sleep(2000);
            Console.WriteLine("[item updated]");
        }
        public static void delete(toDoAppContext _toDo)
        {
            Console.WriteLine("Enter the item id #.");
            int idi = Convert.ToInt32(Console.ReadLine());
            Item b = _toDo.items.Find(idi);
            _toDo.items.Remove(b);
            _toDo.SaveChanges();
            Thread.Sleep(2000);
            Console.WriteLine("[item deleted]");

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