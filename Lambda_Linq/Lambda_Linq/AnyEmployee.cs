using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lambda_Linq
{
    internal class AnyEmployee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public String Designation { get; set; }
        public String Department { get; set; }
        public static List<AnyEmployee> GetAllEmployees()
        {
            List<AnyEmployee> EmpList = new List<AnyEmployee>()
            {
                new AnyEmployee { Id = 14, Name ="Mukta", Salary = 10.4, Designation = "Developer", Department ="AIML"},
                new AnyEmployee { Id = 32, Name ="Vaish", Salary = 6.5, Designation = "Manager", Department="Financial" },
                new AnyEmployee { Id = 13, Name ="Ashwati", Salary = 7.4, Designation = "System Engineer", Department ="Testing"},
                new AnyEmployee { Id = 27, Name ="Anu", Salary = 12.6, Designation ="Data Scientist", Department = "AIML"},
                new AnyEmployee { Id = 23, Name ="Shri", Salary = 5.6, Designation =".Net Developer", Department = "Development"},
                new AnyEmployee { Id = 13, Name ="Ashwati", Salary = 7.4, Designation = "System Engineer", Department ="Testing"},
                new AnyEmployee { Id = 27, Name ="Ragini", Salary = 12.6, Designation ="Data Scientist", Department = "AIML"}
            };
            return EmpList;
        }

        public static void Display()
        {
            try
            {
                var MethSyntax = AnyEmployee.GetAllEmployees().Any(x => x.Salary >= 5 && x.Department == "AIML");
                if (MethSyntax)
                {
                    Console.WriteLine("Atleast one employee of AIML department having salary more than 5");
                }
            }
            catch (Exception ex) 
            { 
                Console.WriteLine(ex.Message);
            }


        }

        //ThenBy Method
        public static void ThenBy()
        {
            //using method syntax
            var MethSyntax = AnyEmployee.GetAllEmployees().OrderBy(x => x.Department).ThenBy(x => x.Name);
            Console.WriteLine("After sorting");
            foreach (var item in MethSyntax)
            {
                Console.WriteLine(item.Department + " " + item.Name);
            }

            //using query syntax
            var QuerySynt = (from emp in AnyEmployee.GetAllEmployees()orderby emp.Salary select emp);
            Console.WriteLine("After Sorting");
            foreach (var item in QuerySynt)
            {
                Console.WriteLine(item.Name+" "+item.Salary);
            }

        }

        //ThenByDescending
        public static void ThenByDesc()
        {
            var MethSynt = AnyEmployee.GetAllEmployees().Where(x => x.Department =="AIML").OrderByDescending(x => x.Department).ThenByDescending(x => x.Name);
            Console.WriteLine("After sorting:");
            foreach(var item in MethSynt)
            {
                Console.WriteLine(item.Department+" "+item.Name);
            }
        }

        public static void Reverse()
        {
            //Method Syntax
            var MethSynt = AnyEmployee.GetAllEmployees().Select(x => x.Name).Reverse();
            foreach(var item in MethSynt)
            {
                Console.WriteLine(item);
            }

            //Query Syntax
            var QuerySynt = (from item in AnyEmployee.GetAllEmployees() select item.Department).Reverse();
            foreach (var item in QuerySynt)
            {
                Console.WriteLine(item);
            }
        }

    }
}
