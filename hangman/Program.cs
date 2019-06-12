//homework-hangman or guessing words

//pick a word randomly from a file, and let users to guess and users get the hint


using System;
using System.IO;

namespace hangman
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines =
            System.IO.File.ReadAllLines(@"C:\Users\jungi\Desktop\words.txt");//read everything
                                                                             //randomly select a line
            Random random = new Random();
            int r = random.Next(lines.Length);
            string secretWord = lines[r];//gets the string word at the random r array
            Console.WriteLine("The secret word is " + secretWord);
            Console.WriteLine("Guess a word");
            string s = Console.ReadLine();
            int intGuess = Array.IndexOf(lines, s);//get the index of the object in the array lines
            int counter = 0;


            while (intGuess != r && counter < 5)
            {

                if (intGuess > r)
                {
                    Console.WriteLine("The word is after the secret word. Try another guess:");
                    string stringGuess2 = Console.ReadLine();
                    intGuess = Array.IndexOf(lines, stringGuess2);
                }
                else if (intGuess < r)
                {
                    Console.WriteLine("The word is before the secret word. Try another guess:");
                    string stringGuess3 = Console.ReadLine();
                    intGuess = Array.IndexOf(lines, stringGuess3);
                }

                counter++;
            }

            if (intGuess == r)
            {
                Console.WriteLine("You got it right");
            }
            else
            {
                Console.WriteLine("You lost the game.");
            }

        }
    }
}

