using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;


namespace toDoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            App app = new App();
            app.start();
        }
    }
    class App
    {
        Dao dao;
        Utils utils;
        public App()
        {
            dao = new Dao();
            utils = new Utils("Prefix");
        }

        public void start()
        {
            utils.printMenu();
            String input = utils.getInput();
        }


        public void add()
        {
            utils.printMsg("Enter an item description.");
            string desc1 = utils.getInput();
            dao.create(desc1);
            Console.WriteLine("[item added]");

        }
        public void listAll()
        {
            var result = from s in dao.listItems()
                         select s;
            foreach (Item i in result)
            {
                Console.WriteLine("{0} {1} {2}", i.id, i.desc, i.done);
            }

        }
        public void markDone()
        {
            utils.printMsg("Enter the item id.");
            int a = Convert.ToInt32(utils.getInput());
     
            Thread.Sleep(2000);
            Console.WriteLine("[item updated]");
        }
        public static void delete(Dao d)
        {
            Console.WriteLine("Enter the item id #.");
            int idi = Convert.ToInt32(Console.ReadLine());
            Item b = d.context.items.Find(idi);
            d.context.items.Remove(b);//why it does return null...
            Console.WriteLine(b.desc);
            d.context.SaveChanges();
            Thread.Sleep(2000);
            Console.WriteLine("[item deleted]");

        }


    }
}