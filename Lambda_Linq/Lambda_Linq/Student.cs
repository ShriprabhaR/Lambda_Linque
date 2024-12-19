using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Collections
{
    internal class Student
    {
        public int USN {  get; set; }
        public String Name { get; set; }

        public static void GetDetails()
        {
            List<Student> list = new List<Student>()
            {
                new Student() { USN = 4, Name = "Shri" },
                new Student() { USN = 1, Name = "Vaish" },
                new Student() { USN = 3, Name = "Anu" }
            };
            var Details = list.Select(x =>x.USN+" "+x.Name);

            foreach (var item in Details)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------");


            //LINQ method - OrderByDescending/ OrderBy
            var NewDetails = list.OrderByDescending(x => x.USN);

            foreach (var item in NewDetails)
            {
                Console.WriteLine(item.USN + " " + item.Name);
            }

        }

    }
}
