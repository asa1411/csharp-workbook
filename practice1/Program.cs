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
                Console.WriteLine("Enter a number or 'ok' to exit.");
                String input1 = Console.ReadLine();
                int input1Number = int.Parse(input1);
                sum = sum + input1Number;
                Console.WriteLine(sum);

            }

        }
    }
}
