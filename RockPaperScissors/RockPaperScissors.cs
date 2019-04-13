using System;

namespace RockPaperScissors
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter hand 1:");
            string hand1 = Console.ReadLine().ToLower();
            Random hand2Generator = new Random();
            int randomHand = hand2Generator.Next(0, 3);

            string hand2 = randomHand.ToString();
            if (randomHand == 0)
            {
                hand2 = "rock";

            }
            else if (randomHand == 1)
            {
                hand2 = "scissors";
            }
            else
            {
                hand2 = "paper";

            }
            Console.WriteLine("The hand of play2 is " + hand2);
            
            Console.WriteLine(CompareHands(hand1, hand2));

            // leave this command at the end so your program does not close automatically
            Console.ReadLine();
        }

        public static string CompareHands(string hand1, string hand2)
        {
            // Your code here
            if (hand1 == hand2)
            {
                return "It's a tie!";
            }

            if (hand1 == "rock")
            {
                if (hand2 == "scissors")
                {
                    return "Hand one wins!";
                }
                // If we reach here, player 2 must have dealt paper
                return "Hand two wins!";
            }

            if (hand1 == "paper")
            {
                if (hand2 == "rock")
                {
                    return "Hand one wins!";
                }
                return "Hand two wins!";
            }

            if (hand1 == "scissors")
            {
                if (hand2 == "paper")
                {
                    return "Hand one wins!";
                }
                return "Hand two wins!";
            }
            return hand1 + ' ' + hand2;
        }
    }
}
