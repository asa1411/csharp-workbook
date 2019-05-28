using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentList
{
	public class Program
	{
		public static void Main()
		{
		List<Student> students = new List<Student>();
		
		students.Add(new Student("Chris", "123-456-7891", "123 Delany", -2990));
		students.Add(new Student("Kevin", "512-222-2222", "435 Carolyn", -2500));
		students.Add(new Student("Victoria", "512-827-8498", "701 Brazos St", 0));
		students.Add(new Student("Luke", "555-555-5555", "451 Brody Ln", -500));
		
		
			IEnumerable<string> results =//string : what comes out at last
            students//starting point, person(s) come out
            .Where (p=>p.Balance<0)//person go in, person comes out
            .OrderBy (p =>p.Name) //perosn goies in, person goes out
            //see the bottom
            .Select(p => p.Name); //person goes in, string come out
			
			foreach(string n in results)
			{
				Console.WriteLine(n);
			}

		}
		
			

	}
	
	public class Student
	{
		public string Name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
		public int Balance { get; set; }
		
		public Student (string name, string phone, string address, int balance)
		{
			Name = name;
			Phone = phone;
			Address = address;
			Balance = balance;
		}
	}
}