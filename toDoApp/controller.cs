using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;


namespace toDoApp
{
    class Controller
    {
        public static void homescreen(Dao d)
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
                add(d);

            }
            if (input == "list all")
            {
                listAll(d);
            }
            if (input == "mark done")
            {
                markDone(d);
            }
            if (input == "delete")
            {
                delete(d);
            }
        }
        public static void add(Dao d)
        {
            Console.WriteLine("Enter an item description.");
            string desc1 = Console.ReadLine();

            Item myItem = new Item(desc1, Status.pending);
            d.context.items.Add(myItem);
            d.context.SaveChanges();
            Console.WriteLine("[item added]");

        }
        public static void listAll(Dao d)
        {
            var result = from s in d.context.items
                         select s;
            foreach (Item i in result)
            {
                Console.WriteLine("{0} {1} {2}", i.id, i.desc, i.status);
            }

        }
        public static void markDone(Dao d)
        {
            Console.WriteLine("Enter the item id.");
            int id2 = Convert.ToInt32(Console.ReadLine());
            Item a = d.context.items.Find(id2);//find the item of id i from Dbset items in context
            Console.WriteLine(a);
            a.status = Status.done;
            d.context.SaveChanges();
            Thread.Sleep(2000);
            Console.WriteLine("[item updated]");
        }
        public static void delete(Dao d)
        {
            Console.WriteLine("Enter the item id #.");
            int idi = Convert.ToInt32(Console.ReadLine());
            Item b = d.context.items.Find(idi);
            d.context.items.Remove(b);//why it does return null...
            Console.WriteLine(b);
            d.context.SaveChanges();
            Thread.Sleep(2000);
            Console.WriteLine("[item deleted]");

        }

        static void Main(string[] args)
        {

            Dao dao = new Dao();
            toDoAppContext _toDo = new toDoAppContext();

            Controller.homescreen(dao);

            foreach (Item i in dao.listItems())
            {
                Console.WriteLine(" ");
            }
        }
    }
}