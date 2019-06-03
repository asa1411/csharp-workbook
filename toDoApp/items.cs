using System;

namespace toDoApp
{

    public class Item
    {
        public int id { get; set; }
        public string desc { get; set; }
        // public Status status { get { return privateobject; } set { privateobject = value; } }
        public Status status;
        // private Status privateobject;
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
    public enum Status
    {
        pending, done, tobedone
    }

}