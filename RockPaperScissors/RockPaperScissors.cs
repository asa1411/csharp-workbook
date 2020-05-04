﻿using System;
using System.Collections.Generic;

namespace RockPaperScissors
{
    class Program
    {
        public static void Main()
        {
            int counter = 1;
            int H2 = 0;
            int H1 = 0;
            int Tie = 0;
            while (counter <= 5)
            {
                Console.WriteLine("Enter hand 1:");
                string hand1 = Console.ReadLine().ToLower();
                try
                {
                    if (hand1 != "rock" && hand1 != "scissors" && hand1 != "paper")
                        throw (new Exception("You got an error and try again."));
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    //continue repeats commands above it until if clause meets the requirement
                    continue;
                }
                var random = new Random();
                var list = new List<string> { "rock", "paper", "scissors" };
                //list.Count returns the size of the list which is 3.
                //random.Next property has two arguments (inclusive #, exclusive #).
                //It returns a number between inclusive # and (exclusive # -1)
                //When it has a number, it is an exclusive number, and the Next property 
                //returns a number between 0 and (1 less than the number)
                //List is a generic class and it needs system.collections.generic.
                int index = random.Next(list.Count);
                string hand2 = list[index];
                Console.WriteLine("Hand2 is " + hand2);
                Console.WriteLine(CompareHands(hand1, hand2));
                String output = CompareHands(hand1, hand2);
                switch (output)
                {
                    case "it is a tie":
                        Tie++;
                        break;
                    case "hand1 wins.":
                        H1++;
                        break;
                    case "hand2 wins.":
                        H2++;
                        break;
                }
                Console.WriteLine("Hand1 wins #: " + H1 + "   Tie:" + Tie + "   Hand2 wins #:" + H2);
                counter++;

            }


            // leave this command at the end so your program does not close automatically
            Console.ReadLine();
        }

        public static string CompareHands(string hand1, string hand2)
        {
            // Your code here
            if (hand1 == hand2)
                return "it is a tie";


            else if (hand1 == "rock")
            {
                if (hand2 == "scissors")
                    return "hand1 wins.";
                else

                    return "hand2 wins.";


            }
            else if (hand1 == "paper")
            {
                if (hand2 == "rock")
                    return "hand1 wins.";
                else
                {
                    return "hand2 wins.";
                }
            }

            else
            {
                if (hand2 == "paper")
                    return "hand1 wins.";
                else { return "hand2 wins."; }
            }

        }


    }
}
