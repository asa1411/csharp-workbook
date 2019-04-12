using System;

namespace PigLatin
{
    class Program
    {
        public static void Main()
        {
            // your code goes here
            //Write to console two sentences
            //Enter a word in to a console
            Console.WriteLine("Let's make a pigLatin. Please enter a word.");
            //Let the browser read the word that a user enters and declare string variable named input
            string input = Console.ReadLine();

            //declare char variable vowels set to be an array of vowels
            //make a char variable to signify vowels
            char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

            //decare int variable index to be set to index number of first occurrence of any vowel in the string imputLowercase
            int index = input.IndexOfAny(vowels);
            //declare int variable indexLast to be set to the value of last occurrence of any vowel in the string imputLowercase
            int indexLast = input.LastIndexOfAny(vowels);

            //declare string variable beforeIndex to be set to the substring which starts from a letter of index 0 and continue to as many letters as the number of index
            string beforeIndex = input.Substring(0, index);
            //declare string variable afterIndex to be set to the substring which starts from a letter of index number and continue to the end of the string
            string afterIndex = input.Substring(index);
            string space = " ";
            //if statement about vowels come first and last of the string
            if (index == 0 && indexLast == input.Length - 1)
            {//then add yay to the word 
                Console.WriteLine("Your pigLatin is" + space + input + "yay");
            }//if vowel comes first but the word does not end up with a vowel
            else if (index == 0 && indexLast != input.Length - 1)
            {//then add ay to the word
                Console.WriteLine("Your pigLatin is" + space + input + "ay");
            }
            else
            {//if the first letter of the word is not a vowel, then the segment before the first vowel goes back to the the segment after the first vowel and add ay to the switched word
                Console.WriteLine("Your pigLatin is" + space + afterIndex + beforeIndex + "ay");
            }

            // leave this command at the end so your program does not close automatically
            Console.ReadLine();
        }


    }
}
