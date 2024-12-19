using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Lambda_Linq
{
    internal class Person
    {
        public int  Ssn { get; set; }
        public string Name { get; set; }
        public String Address {  get; set; }
        public int Age { get; set; }


        public static List<Person> Display()
        {
            List<Person> PersonList = new List<Person>()
            {
                new Person() { Ssn = 1, Name="Shri", Address="HSR",  Age=22 },
                new Person() { Ssn = 2, Name="Naira", Address="BDA",  Age=30 },
                new Person() { Ssn = 3, Name="Naitik", Address="HSR",  Age=15 },
                new Person() { Ssn = 4, Name="Manish", Address="WTF", Age=60 },
                new Person() { Ssn = 5, Name="Surekha", Address="BDA",  Age=53 }
            };

            return PersonList;
        }

        //To find less than 60
        public static void GetDetails() { 

            var records = Person.Display().Where(x => x.Age < 60).OrderBy(x => x.Age).Select(x => x.Name).Take(2);

            foreach (var item in records)
            { 
                Console.WriteLine(item);
            }
            Console.WriteLine("---------");
        }

        //To find person's age between 13 and 18
        public static void GetRecords()
        {
            var records1 = (from item in Person.Display() where item.Age >= 13 && item.Age <= 18 select item.Name);
            foreach (var item in records1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("--------");
        }

        //To get avg of ages
        public static void GetAvg()
        {
            var records2 = Person.Display();

            double AvgAge = records2.Average(x => x.Age);
           
                Console.WriteLine("Average age: "+AvgAge);
        }

        //To check presence
        public static void Check()
        {
           var record3 = Person.Display().Where(x => x.Name.Contains("Shri"));

            foreach (var item in record3) 
            { 
                Console.WriteLine(item.Name); 
            }
        }
    }
}
