using System;

namespace EF
{
    public class Book
    {
        public int id {get; private set;}
        public String title {get; private set;}
        public Type type {get; private set;}
        
        public Book()
        {}
        
        public Book(String iTitle, Type iType)
        {
            this.title = iTitle;
            this.type = iType;
        }
    }    

    public enum Type
    {
        Biography, Fiction, Kids
    }
}