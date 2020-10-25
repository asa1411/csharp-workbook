using System;

namespace Object
{
   public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Jungil!");
           tool hammer = new tool ();
           tool saw = new tool ();
           hammer.type = "hometool";
           hammer.size = "short";
           saw.type = "hometool";
           saw.size = "medium";
            Console.WriteLine ("Hammer is for " + hammer.type + ". Its size is " + hammer.size+".");
        }
    }

    public class people
    {
        public string nationality;
        public string color;
        public int age;
        public string career;

    }
    public class tool
    {
        public string type;
        public string size;
    }
}
