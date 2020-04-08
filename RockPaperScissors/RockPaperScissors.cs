using System;
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
            while (counter < 10)
            {
                Console.WriteLine("Enter hand 1:");
                string hand1 = Console.ReadLine().ToLower();
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
                Console.WriteLine(hand2);

                Console.WriteLine(CompareHands(hand1, hand2));
                //Console.ReadLine(); Here is a problem to be resolved.
                if (Console.ReadLine() == "it is a tie")
                {
                    Tie++;
                }
                else if (Console.ReadLine() == "hand1 wins.") { H1++; }
                else { H2++; }
                Console.WriteLine("Hand1 win #: " + H1 + "   Tie:" + Tie + "   Hand2 win #:" + H2);
                counter++;
            }


            // leave this command at the end so your program does not close automatically
            //Console.ReadLine();
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
                {
                    return "hand2 wins.";
                }
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
