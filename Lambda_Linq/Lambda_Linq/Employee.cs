using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lambda_Linq
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public String Designation { get; set; }
        public String Department { get; set; }
        public static List<Employee> GetAllEmployees()
        {
            List<Employee> EmpList = new List<Employee>()
            {
                new Employee { Id = 14, Name ="Mukta", Salary = 10.4, Designation = "Developer", Department ="AIML"},
                new Employee { Id = 32, Name ="Vaish", Salary = 6.5, Designation = "Manager", Department="Financial" },
                new Employee { Id = 13, Name ="Ashwati", Salary = 7.4, Designation = "System Engineer", Department ="Testing"},
                new Employee { Id = 27, Name ="Anu", Salary = 12.6, Designation ="Data Scientist", Department = "AIML"},
                new Employee { Id = 23, Name ="Shri", Salary = 5.6, Designation =".Net Developer", Department = "Development"},
                new Employee { Id = 13, Name ="Ashwati", Salary = 7.4, Designation = "System Engineer", Department ="Testing"},
                new Employee { Id = 27, Name ="Ragini", Salary = 12.6, Designation ="Data Scientist", Department = "AIML"},
                new Employee { Id = 23, Name ="Shri", Salary = 5.6, Designation =".Net Developer", Department = "Development"}
            };

            return EmpList;

        }

        public static void GetEmp()
        {
            //Method Syntax for select method
            var MethSyntax = Employee.GetAllEmployees();
            foreach (var emp in MethSyntax)
            {
                Console.WriteLine("ID: "+emp.Id +" "+"Name: "+emp.Name+" "+"Salary: "+emp.Salary+" "+"Designation: "+emp.Designation);
            }

            Console.WriteLine("_________________");
            //Query syntax for select method
            var QuerySyntax = (from emp in Employee.GetAllEmployees() select emp);
            foreach (var emp in QuerySyntax)
            {
                Console.WriteLine("ID: " + emp.Id + " " + "Name: " + emp.Name + " " + "Salary: " + emp.Salary + " " + "Designation: " + emp.Designation);
            }

            //Method syntax for where method
            var MethSyntax1 = Employee.GetAllEmployees().Where(x => x.Department == "AIML").ToList();
            foreach (var emp in MethSyntax1)
            {
                Console.WriteLine(emp.Name);
            }

            //Query syntax for where method
            var QuerySyntax1 = (from emp in Employee.GetAllEmployees() where emp.Designation == "Manager" select emp).ToList();
            foreach (var emp in QuerySyntax1)
            {
                Console.WriteLine(emp.Name);
            }

        }


        public static void DisplayEmp()
        {
            //Method Syntax for Distinct method
            var MethodSynt1 = Employee.GetAllEmployees().Select(x => x.Id).Distinct();
            foreach (var emp in MethodSynt1)
            {
                Console.WriteLine(emp);
            }

            //Query Syntax for Distinct method
            var QuerySynt1 = (from emp in Employee.GetAllEmployees() select emp.Name).Distinct().ToList();
            foreach (var emp in QuerySynt1)
            {
                Console.WriteLine(emp);
            }

            //for Empty method
            var EmptyMeth = Employee.GetAllEmployees() ?? Enumerable.Empty<Employee>();
            if (EmptyMeth != null)
            {
                foreach (var emp in EmptyMeth)
                {
                    Console.WriteLine("Employee Name: "+emp.Name);
                }
            }
        }

        //Single method
        public static void SingleImpl()
        {
            try
            {
                var MethSynt = Employee.GetAllEmployees().Single(x => x.Id == 23);
                Console.WriteLine(MethSynt.Name);

                var QuerySynt = (from item in Employee.GetAllEmployees() select item).Single(x => x.Id == 32);
                Console.WriteLine(QuerySynt.Name);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        //SingleOrDefault method
        public static void SingleOrDefaultImpl()
        {
            try
            {
                var MethSynt = Employee.GetAllEmployees().SingleOrDefault(x => x.Id == 14);
                Console.WriteLine(MethSynt.Name);

                var QuerySynt = (from item in Employee.GetAllEmployees() select item).SingleOrDefault(x => x.Id == 32);
                Console.WriteLine(QuerySynt.Name);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            
        }
        //Last Method
        public static void LastImpl()
        {
            try
            {
                var MethSynt = Employee.GetAllEmployees().Last();
                Console.WriteLine(MethSynt.Name);

                var QuerySynt = (from item in Employee.GetAllEmployees() select item).Last(X => X.Department == "AIML");
                Console.WriteLine(QuerySynt.Name + " " + QuerySynt.Department);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        //All method
        public static void AllImpl()
        {
            try
            {
                var methSyntax = Employee.GetAllEmployees().All(x => x.Salary > 5);
                if (methSyntax)
                {
                    Console.WriteLine("All employees getting salary above 5");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

    }
}
