using System;
using System.Collections.Generic;

namespace Checkpoint1
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("Hello World!");

            DivisibleByThree();

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Sum Question");
            Sum();

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Factorial Question");
            Factor();
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Picking a random number");
            RandomNumber();
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Finding a maximum number");
            Max();


        }
        static void DivisibleByThree()
        {//1- Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder. Display the count on the console.
            int num1 = 0;
            int counter = 0;
            for (num1 = 1; num1 <= 100; num1++)
            {
                if (num1 % 3 == 0)
                {
                    counter++;
                    Console.WriteLine(num1 + " is divisible by 3. Count: " + counter);
                }
                else
                {
                    Console.WriteLine(num1);
                }
            }

            // return counter;
        }

        static void Sum()
        {//2- Write a program and continuously ask the user to enter a number or "ok" to exit. Calculate the sum of all the previously entered numbers and display it on the console.

            Console.WriteLine("Enter a number or enter ok to exit");

            string response = Console.ReadLine();

            int sum = 0;
            while (response != "ok")
            {
                int num = Convert.ToInt32(response);
                sum = sum + num;
                Console.WriteLine("Enter a number or ok to exit");
                response = (Console.ReadLine());
            }
            Console.WriteLine("Thank you. The sum is " + sum);
        }
        static void Factor()
        {//Write a program and ask the user to enter a number. Compute the factorial of the number and print it on the console. For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.

            Console.WriteLine("Write a number, and you will get a factorial of the number.");
            int input = Convert.ToInt32(Console.ReadLine());
            int factorial = input;

            for (int i = 1; i < input; i++)
            {
                factorial = factorial * (input - i);

            }

            Console.WriteLine(input + "! = " + input);

        }

        static void RandomNumber()
        {//Write a program that picks a random number between 1 and 10. Give the user 4 chances to guess the number. If the user guesses the number, display “You won"; otherwise, display “You lost". (To make sure the program is behaving correctly, you can display the secret number on the console first.) 
            List<int> pickNumber = new List<int>();

            Random random = new Random();
            int num = random.Next(1, 10);
            Console.WriteLine("The number you need to pick to win is " + num);
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Enter a number between 1 and 10");
                int input = int.Parse(Console.ReadLine());
                pickNumber.Add(input);
            }


            if (pickNumber[0] == num || pickNumber[1] == num || pickNumber[2] == num || pickNumber[3] == num)
            { Console.WriteLine("You won"); }
            else { Console.WriteLine("You lost"); }
        }

        static void Max()
        {//Write a program and ask the user to enter a series of numbers separated by comma. Find the maximum of the numbers and display it on the console. For example, if the user enters “5, 3, 8, 1, 4", the program should display 8.
            List<int> t = new List<int>();
            Console.WriteLine("Enter a series of numbers separated by comma.");
            string p = (Console.ReadLine());

            foreach (string sn in p.Split(","))
            {
                int s = int.Parse(sn);
                t.Add(s);
            }
            int max = t[0];

            for (int i = 0; i < t.Count; i++)
            {
                int current = t[i];
                if (max < current)
                {
                    max = current;
                }

            }
            Console.WriteLine(max);
        }
    }
}





