using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lambda_Linq
{
    internal class Last
    {
        public static void Display()
        {
            try
            {
                int[] arr = { 30, 60, 36, 29, 50 };

                var methSyntax = arr.Last();
                Console.WriteLine(methSyntax);

                var QuerySyntax = (from item in arr select item).Last();
                Console.WriteLine(QuerySyntax);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public static void LastOrDefault()
        {
            try
            {
                char[] arr = { 'A', 'U', 'E', 'H', 'M', 'S' };

                var methSyntax = arr.Last();
                Console.WriteLine(methSyntax);

                var QuerySyntax = (from item in arr select item).Last();
                Console.WriteLine(QuerySyntax);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
