using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //ask for one of three hands, R for rock, P for paper, S for scissors
            //take the hand
            //randomly let the computer pick one hand among R, P, and S
            //compare hand of input with hand that computer randomly picked
            //declare which hand wins

            Console.WriteLine("Enter a hand, R for Rock, P for Paper, S for Scissors");
            string hand1 = Console.ReadLine().ToLower();
            Random hand2Generator = new Random ();
            int randomHand = hand2Generator.Next(0,3);
            string hand2 = (string)randomHand;
            if(randomHand==0){hand2="r";}
            Console.WriteLine(compareHands(hand1, hand2));
            Console.ReadLine ();

        }
        public static string compareHands(string hand1 string hand2)
        {

        }
    }
}
