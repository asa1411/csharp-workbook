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
        {
            Console.WriteLine("Let's play a pigLatingame. Enter a word you want to play with.");
            string input = Console.ReadLine();
            string inputLowercase = input.ToLower();
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            int index = input.IndexOfAny(vowels);
            string beforeIndex = inputLowercase.Substring(0, index - 1);
            string afterIndex = inputLowercase.Substring(index);
            string space = " ";
            Console.WriteLine("Your pigLatin is" + space + afterIndex + beforeIndex + "ay");
        }
    }
}
