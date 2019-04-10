using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");

            int input = Convert.ToInt32(Console.ReadLine());
            if (input > 0)
            {

                Console.WriteLine("positive");

            }
            else if (input < 0)
            {
                Console.WriteLine("negative");
            }
            else
            {
                Console.WriteLine("zero");
            }
        }
    }
}
