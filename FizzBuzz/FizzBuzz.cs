﻿using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 1;
            while (counter <= 100)
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
                counter++;
            }
        }
    }
}
