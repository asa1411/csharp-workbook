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

        static void Question1(string[] args)
        {
            int x;
            int y;
            //ask a user to enter a number to the console
            Console.WriteLine("Enter a number.");
            //declare a variable called input1 and set it to the data a user enters
            string input1 = Console.ReadLine();
            //decalre a variable called x and set it to the value that the data is converted to 

            x = Convert.ToInt32(input1);
            //ask a user to enter another number to the console
            Console.WriteLine("Enter another number.");
            //declare a variable called input2 and set it to the data a user enters
            string input2 = Console.ReadLine();
            //declare a variable called y and set it to the value that the data is converted to
            y = Convert.ToInt32(input2);
            //declare a variable called sum and set it to the sum of x and y
            int sum = x + y;
            //Console writes the sum in a equation
            Console.WriteLine("The sum of the two numbers = " + sum);
        }
        static void Question2(string[] args)
        {
            //make a variable y
            decimal y;
            //ask a user to enter a number in yard.
            Console.WriteLine("Enter a number in yard.");
            //make a string variable input and set it to what a user enters to the console.
            string input = Console.ReadLine();

            //set number variable y to the input value which is converted into a number
            // y = Convert.ToInt32(input);
            y = decimal.Parse(input);
            //make a variable i and set it to 32*y
            decimal i = y * 32;
            //write the variable i on the console
            Console.WriteLine(y + " in yard = " + i + " in inch.");
        }
        static void Question3(string[] args)
        {
            bool people = true;
            Console.WriteLine(people.GetType());
        }
        static void Question4(string[] args)
        {
            bool f = false;
            Console.WriteLine(f.GetType());
        }
        static void Question5(string[] args)
        {//To write a decimal value, m or M is required to follow the decimal number
            decimal myDecimal = 345.0m;
            Console.WriteLine(myDecimal.GetType());
            Console.WriteLine(myDecimal);
        }
        static void Question6(string[] args)
        {
            decimal num = 546;
            num = num * num;
            Console.WriteLine(num);

        }
        static void Question7and8(string[] args)
        {
            string firstName = "Jungil";
            string lastName = "Cho";
            int age = 61;
            string job = "science teacher";
            string favoriteBand = "four sheep";
            string favoriteSportsTeam = "Dollas Cowboys";
            string space = " ";
            Console.WriteLine("full name: " + firstName + space + lastName);
            Console.WriteLine("age: " + age);
            Console.WriteLine("My job is " + job + ".");
            Console.WriteLine("My favorite band is " + favoriteBand + ".");
            Console.WriteLine("My favorite sports team is" + space + favoriteSportsTeam + ".");
        }

        static void Question9(string[] args)
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
            decimal nuM = 123.0098m;
            // int i = Convert.ToInt32(nuM);
            int i = (int)nuM;
            Console.WriteLine(i.GetType());
            Console.WriteLine(nuM.GetType());
            Console.WriteLine(i);
        }
        static void Question10(string[] args)
        {
            int a = 100;
            int b = 10;
            int sum = a + b;
            int product = a * b;
            int diff = a - b;
            int quot = a / b;
            string space = " ";
            Console.WriteLine("The sum of 100 and 10 =" + space + sum + ".");
            Console.WriteLine("The product of 100 and 10 =" + space + product + ".");
            Console.WriteLine("The difference of 100 and 10 =" + space + diff + ".");
            Console.WriteLine("The quotient of 100 and 10 =" + space + quot + ".");

        }
    }
}
