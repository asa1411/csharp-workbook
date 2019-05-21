using System;
using System.Collections.Generic;
using System.Linq;
namespace week7_2
{
    class Program
    {
        static void Main(string[] args);
        List<Student> students = new List<Student>();
        students.Add(new Student("Mark", 4));
        students.Add(new Student("Mary", 5));
        students.Add(new Student("Bob", 4));
        students.Add(new Student("Matt", 3));
        IEnumberable<Student> lessThanSix = students.Where(s => s.age < 6)
        .Where(x => x.name.StartsWith("M"));
        Utils.printMsg();
    IEnumberable<string> lessThanSixOnly = students.Where(s => s.age < 6)
    .Where(x => x.name.StartsWith("M"))
    .Select(s => s.name);

        foreach(Student t in lessThanSix)
        {
            Console.WriteLine(t.name);
        }
    String select1(Student s)
    {
        return s.name;
    }

    bool filter(Student s)
    {
        return s.age < 6;
    }
    bool filter2(Student x)
    {
        return x.name.StartsWith("M");
    }


}
public class Student
{
    public string name { get; set; }
    public int age { get; set; }
    public Student(string initialName, int initialAge)
    {
        this.name = initialName;
        this.age = initialAge;
    }
}
public class Utils
{
    public String msgPrefix { get; set; }
    public Utils(String customPrefix)
    {
        this.msgPrefix = customPrefix;
    }
    public static void printMsg(string msg)
    {
        Console.WriteLine("{0}", msg);
        //I cannot use nonstatic field (instances) to a static method. 
        //to use nonstatic instance, you need to instantiate the method.
    }

    public static void printError(string error)
    {
        Console.WriteLine("[error:  ]");
    }

}

}
