using System;
using System.Collections.Generic;

namespace challenge
{
    class Program
    {
        static void Main(string[] args)
        {//Write a program that asks the user for 5 integers. 
         //Handle the user giving you non-integer input.
            int sum = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter a number.");
                try
                {
                    int number = Convert.ToInt32(Console.ReadLine());
                    sum = sum + number;

                }
                catch (Exception e)
                {
                    Console.WriteLine("Something went wrong.");
                    Console.WriteLine("the message from the exception is " + e.Message);

                }
                finally
                {
                    Console.WriteLine("Thank you.");
                }

                Console.WriteLine("The sum is " + sum);
            }



        }
    }
}
