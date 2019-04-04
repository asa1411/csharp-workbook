using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("What is your name?");
            string input = Console.ReadLine();
            Console.WriteLine("Nice to meet you " + input);
        }
    }
}
