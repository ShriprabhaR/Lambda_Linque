using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lambda_Linq
{
    internal class FirstOfLinq
    {
        public static void Display()
        {
            int[] arr = { 10, 400, 60, 20, 603 };
            //method syntax
            var MethodSyntax = arr.First();
            Console.WriteLine(MethodSyntax);

            //query syntax
            var QuerySyntax = (from item in arr select item).First();
            Console.WriteLine(QuerySyntax);
        }

        
    }
}
