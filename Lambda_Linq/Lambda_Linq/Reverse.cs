using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lambda_Linq
{
    internal class Reverse
    {
        public static void Display()
        {
            int[] arr = { 23, 26, 57, 94 };

            var Reversed = arr.Reverse();
            foreach (int i in Reversed)
            {
                Console.WriteLine(i);
            }

            var Reverse = (from item in arr select item).Reverse();
            foreach (int i in Reverse)
            {
                Console.WriteLine(i);
            }
        }
    }
}
