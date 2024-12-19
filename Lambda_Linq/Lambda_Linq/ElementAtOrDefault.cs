using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lambda_Linq
{
    internal class ElementAtOrDefault
    {
        public static void Display()
        {
            int[] arr = { 10, 40, 60, 30, 20, 80 };

            //Method syntax
            var MethodSyntax = arr.ElementAtOrDefault(-1);
            Console.WriteLine(MethodSyntax);

            //Query syntax
            var QuerySyntax = (from item in arr select item).ElementAtOrDefault(3);
            Console.WriteLine(QuerySyntax);
        }
    }
}
