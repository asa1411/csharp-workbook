﻿using System;

namespace practice1
{
    class Program
    {
        static void Main(string[] args)
        {
            Sum();
            Console.WriteLine();
            Console.WriteLine("This is the factorial question.");
            factorial();
            Console.WriteLine();
            Console.WriteLine("This is the random number question.");
            randomNumber();


        }
        static void Sum()
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

        static void factorial()
        {

            Console.WriteLine("Enter a number. ");
            String input = Console.ReadLine();
            int inputNumber = Convert.ToInt32(input);
            int factorial = inputNumber;
            for (int i = 1; i < inputNumber; i++)
            {
                factorial = factorial * i;
            }
            Console.WriteLine($"The {inputNumber}! is {factorial}.");
        }

        static void randomNumber()
        {
            Random random = new Random();
            int num = random.Next(1, 11);
            Console.WriteLine("The random number is " + num);
            Console.WriteLine("Enter a number between 1 and 10.");
            int input = int.Parse(Console.ReadLine());
            int counter = 0;
            while (num != input && counter != 3)
            {
                Console.WriteLine("Enter a number");
                input = int.Parse(Console.ReadLine());
                counter++;
            }
            if (num == input)
            {
                Console.WriteLine("You won.");
            }
            else Console.WriteLine("You lost.");
        }
    }
}

