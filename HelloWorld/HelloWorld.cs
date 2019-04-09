using System;

namespace HelloWorld
{
    class Program
    {

        static void Main(string[] args)
        {   //Write to console two sentences
            Console.WriteLine("Let's play a pigLatingame.");
            Console.WriteLine("Enter a word you want to play with.");
            //Let the browser read the word that a user enters and declare string variable named input
            string input = Console.ReadLine();
            //Convert all letters to lowercase and declare lowercased string as variable inputLowercase 
            string inputLowercase = input.ToLower();
            //declare char variable vowels set to be an array of vowels
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            //decare int variable index to be set to index number of first occurrence of any vowel in the string imputLowercase
            int index = inputLowercase.IndexOfAny(vowels);
            //declare int variable indexLast to be set to the value of last occurrence of any vowel in the string imputLowercase
            int indexLast = inputLowercase.LastIndexOfAny(vowels);

            //declare string variable beforeIndex to be set to the substring which starts from a letter of index 0 and continue to as many letters as the number of index
            string beforeIndex = inputLowercase.Substring(0, index);
            //declare string variable afterIndex to be set to the substring which starts from a letter of index number and continue to the end of the string
            string afterIndex = inputLowercase.Substring(index);
            string space = " ";
            //if statement about vowels come first and last of the string
            if (index == 0 && indexLast == inputLowercase.Length - 1)
            {//then add yay to the word 
                Console.WriteLine("Your pigLatin is" + space + inputLowercase + "yay");
            }//if vowel comes first but the word does not end up with a vowel
            else if (index == 0 && indexLast != inputLowercase.Length - 1)
            {//then add ay to the word
                Console.WriteLine("Your pigLatin is" + space + inputLowercase + "ay");
            }
            else
            {//if the first letter of the word is not a vowel, then the segment before the first vowel goes back to the the segment after the first vowel and add ay to the switched word
                Console.WriteLine("Your pigLatin is" + space + afterIndex + beforeIndex + "ay");
            }


        }
    }
}
