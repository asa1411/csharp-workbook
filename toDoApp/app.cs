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
            if (input != "quit")
            {
                if (input == "add")
                {
                    add();
                    try
                    {
                        utils.printMsg("Do you want to add another item? y or n");
                        string r = utils.getInput().ToLower();
                        while (r == "y")
                        {
                            add();
                            utils.printMsg("Do you want to add another item? y or n");
                            r = utils.getInput().ToLower();
                        }
                        
                    }
                    catch
                    {
                        utils.printError("Your input is not valid. Try again.");
                    }

                }
                else if (input == "delete")
                {
                    delete();

                }
                else if (input == "mark done")
                {
                    markDone();

                }
                else if (input == "list all")
                {
                    listAll();

                }
                else if (input == "list pending")
                {
                    dao.listPendingItems();

                }
                else if (input == "list done")
                {
                    dao.listDoneItems();
                }
                else
                {
                    utils.printError("Your input is not valid. Try again");




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

        public void delete()
        {
            try
            {
                utils.printMsg("Enter the item id #.");
                int idi = Convert.ToInt32(utils.getInput());
                dao.delete(idi);
                Thread.Sleep(2000);
                Console.WriteLine("[item deleted]");
            }
            catch
            {
                utils.printError("Your input is invalid. Try again");
            }

        }

        public void markDone()
        {
            try
            {
                utils.printMsg("Enter the item id.");
                int a = Convert.ToInt32(utils.getInput());
                dao.markDone(a);
                Thread.Sleep(2000);
                Console.WriteLine("[item updated]");
            }
            catch
            {
                utils.printError("Your input is invalid. Try again");
            }
        }
        public void listAll()
        {
            dao.listItems();
        }
    }
}