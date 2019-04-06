using System;

namespace PigLatin
{
    class Program
    {
        public static void Main()
        {
            // your code goes here
            //Enter a word in to a console
            Console.WriteLine("Let's make a pigLatin. Please enter a word.");
            //Read the word
            string input = Console.ReadLine();
            //make a string variable to signify vowels
            string [] vowels = {"a","e", "i", "o", "u", "A", "E", "I", "O", "U"};
            
            

            // leave this command at the end so your program does not close automatically
            Console.ReadLine();
        }
        
        
    }
}
