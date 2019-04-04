using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {// write a program that greets you and ask for your name
        Console.WriteLine("Hello, What is your name?");
        String input = Console.ReadLine();
        Console.WriteLine("Nice to meet you " + input);
        }
    }
}
