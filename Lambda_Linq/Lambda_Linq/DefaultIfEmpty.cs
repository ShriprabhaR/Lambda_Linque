using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lambda_Linq
{
    internal class DefaultIfEmpty
    {
        public static void Display()
        {
            //int[] arr = { 1, 2, 3, 4, 5};

            var arr = new List<int>();

            var MethSynt = arr.DefaultIfEmpty(4);
            foreach (var i in MethSynt)
            {
                Console.WriteLine(MethSynt);
            }

            var QuerySynt = (from item in arr select item).DefaultIfEmpty(3);
            foreach (var i in QuerySynt)
            {
                Console.WriteLine(QuerySynt);
            }


        }
    }
}
