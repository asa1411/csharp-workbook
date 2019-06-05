using System;

namespace toDoApp
{

    public class Item
    {
        public int id { get; private set; }
        public string desc { get; private set; }
        // public Status status { get { return privateobject; } set { privateobject = value; } }
        public bool done {get; set;}
        // private Status privateobject;
        //default constructor
        public Item()
        {

        }
        public Item(string iItems, bool done)
        {
            this.desc = iItems;
            this.done = false;
        }
    }
    // public enum Status
    // {
    //     Pending, Done
    // }

}