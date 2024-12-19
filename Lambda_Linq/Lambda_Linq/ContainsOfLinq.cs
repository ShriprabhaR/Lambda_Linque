using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lambda_Linq
{
    internal class ContainsOfLinq
    {
        public static void Display()
        {
            String[] arr = {"Vaish", "Anu", "Vaibhavi"};

            var MethodSyntax = arr.Contains("Vaish");
            Console.WriteLine(MethodSyntax);

            var QuerySyntax = (from item in arr select item).Contains("Vaibhu");
            Console.WriteLine(QuerySyntax);

        }

        public static void Display1()
        {
            int[] arr = { 1, 2, 3 };

            var MethodSyntax = arr.Contains(4);
            Console.WriteLine(MethodSyntax);

            var QuerySyntax = (from item in arr select item).Contains(2);
            Console.WriteLine(QuerySyntax);
        }

        public static void Display2()
        {
            String[] arr = { "Vaish", "Anu", "Vaibhavi" };

            var MethodSyntax = arr.Where(x => x.Contains("V"));
            foreach (String item in MethodSyntax)
            {
                Console.WriteLine(item);
            }

            var QuerySyntax = from name in arr
                              where name.Contains('v')
                              select name;
            foreach (String item in QuerySyntax)
            {
                Console.WriteLine(item);
            }

        }
    }
}
