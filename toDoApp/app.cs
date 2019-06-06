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
            utils = new Utils("ToDoList: ");
        }

        public void start()
        {
            utils.printMenu();
            String input = utils.getInput();
            while (input != "quit")
            {
                if (input == "add")
                {
                    add();
                    break;
                }
                else if (input == "delete")
                {
                    delete();
                    break;
                }
                else if (input == "mark done")
                {
                    markDone();
                    break;
                }
                else if (input == "list all")
                {
                    listAll();
                    break;
                }
                else if (input == "list pending")
                {
                    dao.listPendingItems();
                    break;
                }
                else
                {
                    utils.printError("Your input is not valid. Try again");
                    break;



                }
            }
            utils.printMsg("Have a nice day");
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
            dao.listItems();
        }
        public void markDone()
        {
            utils.printMsg("Enter the item id.");
            int a = Convert.ToInt32(utils.getInput());
            dao.markDone(a);
            Thread.Sleep(2000);
            Console.WriteLine("[item updated]");
        }
        public void delete()
        {
            utils.printMsg("Enter the item id #.");
            int idi = Convert.ToInt32(utils.getInput());
            dao.delete(idi);
            Thread.Sleep(2000);
            Console.WriteLine("[item deleted]");

        }



    }
}