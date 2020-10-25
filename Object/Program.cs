using System;

namespace Object
{
   public class Program
    {
        static void Main(string[] args)
        {
          school s1 = new school ("Cedar Ridge High School");
            s1.type="private";
            s1.size=2000;
            s1.level="high";

            Console.WriteLine("s1 is {0} and it is a {1} school and its size is {2}.", s1.name, s1.type, s1.size);
        }
    }

    public class school
    {
        public string type;
        public int size;
        public string level;
        public string name;

        public school (string initialName)
        {
            this.name = initialName;
        }

    }
}
