using System;

namespace HelloWorld
{
    class Program
    {
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
        {
            decimal myDecimal = 345;
            Console.WriteLine(myDecimal.GetType());
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

        static void Main(string[] args)
        {
            double nuM = 123.0098;
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
