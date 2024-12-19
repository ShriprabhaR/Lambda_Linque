using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lambda_Linq
{
    internal class MinMax
    {
        public static void Display()
        {
            try
            {
                int[] arr = new int[] { 2, 7, 9, 3, 6 };

                var Minimum = arr.Min();
                var Maximum = arr.Max();

                Console.WriteLine(Minimum + " - " + Maximum);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
