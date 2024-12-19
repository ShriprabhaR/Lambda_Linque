using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lambda_Linq
{
    internal class DistinctMethodOfLinq
    {
        public static void Display()
        {
            int[] arr = { 10, 50, 20, 70, 50, 70, 10 };

            //using method syntax
            var MethodSynt = arr.Distinct();
            Console.WriteLine("Distinct elements");
            foreach (int item in MethodSynt)
            {
                Console.WriteLine(item);
            }

            //Using Query Syntax
            var QuerySynt = (from item in arr select item).Distinct();
            Console.WriteLine("Distinct elements");
            foreach (int item in QuerySynt)
            {
                Console.WriteLine(item);
            }
        }
    }
}
