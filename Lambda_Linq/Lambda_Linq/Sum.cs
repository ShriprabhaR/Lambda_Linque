using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lambda_Linq
{
    internal class Sum
    {
        public static void Display()
        {
            try
            {
                int[] arr = new int[] { 3, 23, 54, 12 };

                //Method syntax
                var Sum = arr.Sum();
                Console.WriteLine(Sum);

                //Query Syntax
                var Sum2 = (from item in arr select item).Sum();
                Console.WriteLine(Sum2);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
