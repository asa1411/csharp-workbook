using System;
using System.Collections.Generic;

namespace RockPaperScissors
{
    class Program
    {//declare three int variables uninitiated
        public static int ComputerScore;
        public static int PlayerScore;
        public static int TieScore;

        public static void Main()
        {
            try
            {
                Console.WriteLine("Enter hand 1:");
                string hand1 = Console.ReadLine().ToLower();
                //Generate random number under a name "randomHand"
                Random hand2Generator = new Random();
                int randomHand = hand2Generator.Next(0, 3);
                //Assign string hand2 to rock, paper, or scissors according to the if conditions 
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
                //execute CompareHands method with strings hand1 and hand2
                Console.WriteLine(CompareHands(hand1, hand2));
                //write the hand of computer play
                //Write the results of incremental numbers for hand1, hand2 and draw
                Console.WriteLine("Hand1: " + PlayerScore + " wins" + ", Hand2: " + ComputerScore + " wins" + "," + " Ties: " + TieScore);
                Replay();
            }
            catch (Exception)
            {
                Console.WriteLine("You typed wrong.");
            }
        }

        public static void Replay()
        {
            Console.WriteLine("Do you want to play again? Y or N");
            string Choice = Console.ReadLine().ToLower();
            if (Choice == "y")
            {
                Main();
            }
            else
            {
                Console.WriteLine("Thank you for playing.");
            }
        }

        public static string CompareHands(string hand1, string hand2)
        {
            List<string> rps = new List<string>();
            rps.Add("rock");
            rps.Add("scissors");
            rps.Add("paper");
            if (rps.Contains(hand1))
            {
                // Your code here
                if (hand1 == hand2)
                {
                    TieScore++;
                    return "It's a tie!";
                }

                if (hand1 == "rock")
                {
                    if (hand2 == "scissors")
                    {
                        PlayerScore++;
                        return "Hand one wins!";
                    }
                    // If we reach here, player 2 must have dealt paper
                    ComputerScore++;
                    return "Hand two wins!";
                }

                else if (hand1 == "paper")
                {
                    if (hand2 == "rock")
                    {
                        PlayerScore++;
                        return "Hand one wins!";
                    }
                    ComputerScore++;
                    return "Hand two wins!";
                }

                else if (hand1 == "scissors")
                {
                    if (hand2 == "paper")
                    {
                        PlayerScore++;
                        return "Hand one wins!";
                    }
                    ComputerScore++;
                    return "Hand two wins!";
                }


            }
            else
            {
                throw new Exception();//throw an exception when one of the rock, paper and scissors are not entered.
            }

            return hand1 + ' ' + hand2;
        }
    }
}