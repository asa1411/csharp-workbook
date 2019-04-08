using System;

namespace HelloWorld
{
    class Program
    {
        static void practice(string[] args)
        {
            string example = "prtyAnother is Lowercase.";
            //convert any capital letters to lowercase
            string exampleLower = example.ToLower();
            //find the index of a certain character in a string
            int num = exampleLower.IndexOf('l');
            //write to console the string variable exampleLower
            Console.WriteLine(num);
            //write a char variable with an array of vowels
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            //write to console the index of array for character e
            Console.WriteLine(vowels[1]);
            //use substring method, to retrieve substring
            string part = exampleLower.Substring(5);
            Console.WriteLine(part);
            //use IndexofAny method to index of a first occurrance of a character in an array of characters
            int num1 = exampleLower.IndexOfAny(vowels);
            //write the index number 
            Console.WriteLine(num1);
            //split a string into two parts. Declare str1 as part of the string starting from index 0 to index of (num1 -1) which is the number of characters in the string before a vowel is found
            string str1 = exampleLower.Substring(0, num1 - 1);
            //declare str2 as the rest of the string after the first part is removed
            string str2 = exampleLower.Substring(num1);
            Console.WriteLine(str1);
            Console.WriteLine(str2);
        }
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
            //declare string variable beforeIndex to be set to the substring which starts from a letter of index 0 and continue to as many letters as the number of index
            string beforeIndex = inputLowercase.Substring(0, index);
            //declare string variable afterIndex to be set to the substring which starts from a letter of index number and continue to the end of the string
            string afterIndex = inputLowercase.Substring(index);
            string space = " ";
            //declare lastCharacter to set to the last letter of the input string
            char lastCharacter = inputLowercase[inputLowercase.Length - 1];
            //declare firstCharacter to set to the first letter of the input string
            char firstCharacter = inputLowercase[0];
            if ((firstCharacter) && (lastCharacter === vowels))



                Console.WriteLine("Your pigLatin is" + space + afterIndex + beforeIndex + "ay");
            Console.WriteLine(firstCharacter + space + lastCharacter);
        }
    }
}
