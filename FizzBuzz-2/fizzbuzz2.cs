using System;

namespace FizzBuzz2
{
    public class Program2
    {
        public static void Main(string[] args)
        {

            for (int counter = 1; counter <= 100; counter++)

            {
                if (counter % 3 == 0 && counter % 5 != 0)
                {
                    Console.WriteLine("fizz");
                }
                else if (counter % 5 == 0 && counter % 3 != 0)
                {
                    Console.WriteLine("buzz");
                }
                else if (counter % 3 == 0 && counter % 5 == 0)
                {
                    Console.WriteLine("fizz buzz");
                }
                else { Console.WriteLine(counter); }

            }
        }
    }
}
