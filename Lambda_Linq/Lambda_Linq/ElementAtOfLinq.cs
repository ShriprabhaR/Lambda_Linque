using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lambda_Linq
{
    internal class ElementAtOfLinq
    {
        public static void Display()
        {
            int[] arr = { 10, 40, 60, 30, 20, 80 };

            //using method Syntax
            var MethSyntax = arr.ElementAt(3);
            Console.WriteLine(MethSyntax);

            //using query syntax
            var QuerySynt = (from item in arr select item).ElementAt(2);
            Console.WriteLine(QuerySynt);
            
        }
    }
}
