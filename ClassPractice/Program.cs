using System;

namespace ClassPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    public class P
    {
        public Char gender;
        public string name;
        public Person(bool x)
        {
            if (x)
            {
                this.name = "Jane Dee";
                this.gender = 'F';
            }
            else
            {
                this.name = "John Doe";
                this.gender = 'M';
            }
        }
        
    }
}
