using System;

namespace week7_1
{//create a class called address
//has the following properites
//-street1
//-street2
//-city
//-state
//-zip
    class Program
    {
        static void Main(string[] args)
        {  
            Address a1 = new Address();
            DriversLicense d1 = new DriversLicense();
        }
    }
    class Address{
        public string Street1 {get; set;}
        public string Street2 {get; set;}
        public string City {get; set;}
        public string State {get; set;}
        public int Zip {get; set;}
        
    } 
    class DriversLicense
    {
        public string FirstName {get; set;}
        public string LastName {get; set;}
        public Address Address {get; set;}
        public char Gender {get; set;}
        public char LicenseType {get; set;}

    }
    struct Person//small collections of attributes but no hierarchy for inheritance like class. It is used for data holder. When struct is passed, its copy is passed but the origin is still there. When class is passed in, its pointer is passed and the content is changed.
    {
        public string FirstName {get; private set;}
        public string LastName {get; private set;}
        public Person (string s1, string s2)
        {
            this.FirstName = s1;
            this.LastName = s2;
        }
    }
    enum DaysOfWeek {
        //collections of names
        Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday
    }
    enum GenderType {
        male, female
    }
}
