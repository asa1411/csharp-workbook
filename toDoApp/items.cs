using System;

namespace toDoApp
{
    public enum Status
    {
        done, pending
    }
    public class Item
    {
        public int id { get; set; }
        public string desc { get; set; }
        public Status status;
        //default constructor
        public Item()
        {

        }
        public Item(string iItems, Status iDone)
        {
            this.desc = iItems;
            // this.status = iDone;
        }

    }


}