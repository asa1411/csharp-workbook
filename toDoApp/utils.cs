using System;
using System.Threading;

namespace toDoApp
{
    public class Utils
    {
        String msgPrefix;
        public Utils (String customPrefix)
        {
            this.msgPrefix = customPrefix;
        }
        public void printMsg(String msg)
        {
        Console.WriteLine("{0} {1}", this.msgPrefix, msg);
        Thread.Sleep(2000);    
        }

        public void printError(String error)
        {
            Console.WriteLine("[error: {0}]", error);
            Thread.Sleep(2000);
        }
        public void printMenu(){
            Console.WriteLine("Available functions:");
            Console.WriteLine("add: to add an item");
            Console.WriteLine("delete: to delete an item");
            Console.WriteLine("mark done: the item to mark as done");
            Console.WriteLine("list pending: to list the pending items");
            Console.WriteLine("list done: to list done items");
            Console.WriteLine("list all: to list all items");
            Console.WriteLine("quit: to exit");
            Console.WriteLine("What would you like to do?");
                    
        }

        public string getInput()
        { 
            string input = Console.ReadLine();
            return(input);
        }
    }
}