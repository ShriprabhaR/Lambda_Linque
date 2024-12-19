using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lambda_Linq
{
    internal class Single
    {
        //single method
        public static void Display()
        {
            try
            {
                int[] arr = { 10, 40, 20, 60, 30, 35 };

                var MethSynt = arr.Single(x => x > 40);
                Console.WriteLine(MethSynt);

                //If condition satisfies for more than one elements it gives Exception
                var QuerySynt = (from item in arr select item).Single(item => item < 20);
                Console.WriteLine(QuerySynt);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }


        }

        //SingleOrDefault method

        public static void Display1()
        {
            try
            {

                int[] arr = { 10, 40, 20, 60, 30, 35 };
                var MethSynt = arr.SingleOrDefault(x => x > 40);
                Console.WriteLine(MethSynt);

                //If condition satisfies for more than one elements it gives Exception
                var QuerySynt = (from item in arr select item).SingleOrDefault(item => item < 20);
                Console.WriteLine(QuerySynt);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
