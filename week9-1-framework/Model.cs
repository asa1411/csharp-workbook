using System;

namespace week9_1_framework
{

    public class Book
    {
        public int id { get; private set; }
        public string title { get; private set; }
        public Type type { get; private set; }
        public Book()
        {}
        public Book(string iTitle, Type iType)
        {

            this.title = iTitle;
            this.type = iType;
        }

    }
   public enum Type
    {
        Fiction, Bio, Kids
    }
}
