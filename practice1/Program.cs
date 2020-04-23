using System;

namespace practice1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a number or 'ok' to exit.");
            String input = Console.ReadLine();
            int sum = 0;
            while (input != "ok")
            {
                int num = int.Parse(input);
                sum = sum + num;
                Console.WriteLine($"The sum is {sum}.");
                Console.WriteLine("Enter a number or 'ok' to exit.");
                input = Console.ReadLine();

            }
            Console.WriteLine($"Thank you.");
        }
    }
}

