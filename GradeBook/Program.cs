using System;
using System.Collections.Generic;
using System.Collections;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {//1. Your program should ask the user for a set of 5 students and their grades
         //2. It should print the students' name and some statistics about their grades (the grades, min, max, and/or average of the grades and the student name)


            Dictionary<string, string[]> gradebook = new Dictionary<string, string[]>();


            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("What is your name?");
                string names = Console.ReadLine();
                Console.WriteLine("What are your recent three scores? Separate scores by comma");
                string[] grades = Console.ReadLine().Split(',');
                gradebook.Add(names, grades);
            }

            foreach (string names in gradebook.Keys)
            {
                Console.Write("Name: " + names + "; Grades: ");

                string[] grades = gradebook[names];
                int g = int.Parse(grades[0]);
                int Min = g;
                int Max = g;
                int Sum = 0;

                for (int i = 0; i < grades.Length; i++)
                {
                    Sum = Sum + Convert.ToInt32(grades[i]);
                    if (Min >= Convert.ToInt32(grades[i]))
                    {
                        Min = Convert.ToInt32(grades[i]);
                    }
                    if (Max <= Convert.ToInt32(grades[i]))
                    {
                        Max = Convert.ToInt32(grades[i]);
                    }
                    Console.Write(grades[i] + " ");
                }
                Console.WriteLine(" ");
                Console.WriteLine("avg: " + Sum / grades.Length + "; max: " + Max + "; min:" + Min);


            }

        }
    }
}
