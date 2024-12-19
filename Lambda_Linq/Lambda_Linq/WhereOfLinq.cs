using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Collections
{
    internal class WhereOfLinq
    {
        public static void GreaterThan40()
        {
            int[] arr = { 10, 20, 70, 50 };

            //by using method syntax
            var MethodSynt = arr.Where(x => x > 40);

            Console.WriteLine("Greater than 40");
            foreach (var item in MethodSynt)
            {
                Console.WriteLine(item);
            }

            //by using query syntax
            //from, where, select -> Linq methods
            var QuerySynt = (from num in arr where num < 40 select num);

            Console.WriteLine("Less than 40");
            foreach (var item in QuerySynt)
            {
                Console.WriteLine(item);
            }

        }
    }
}
