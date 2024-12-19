using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lambda_Linq
{
    internal class FirstOrDefault
    {
        public static void Display()
        {
            int[] arr = { 1, 2, 3, 6 };

            //Method syntax
            var MethodSyntax = arr.FirstOrDefault();
            Console.WriteLine(MethodSyntax);

            //Query syntax
            var QuerySyntax = (from item in arr select item).FirstOrDefault();
            Console.WriteLine(QuerySyntax);
        }
    }
}
