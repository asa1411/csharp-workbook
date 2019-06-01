using System;

namespace toDoApp
{
    public class Item
    {
        public int id {get; set;}
        public string desc {get; set;}
        public Status done;

        public Item ()
        {

        }
        public Item (string iItems, Status iDone)
        {
            this.desc = iItems;
            this.done = iDone;
        }

        public enum Status
        {
            done, pending
        }
        
    }

}