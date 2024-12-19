using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lambda_Linq
{
    internal class Take
    {
        public static void Display()
        {
            try
            {
                int[] arr = new int[] { 4, 6, 8, 9, 3, 7, 2 };

                //Method syntax
                var Taken = arr.Where(x => x > 4).Take(2);
                foreach (var x in Taken)
                {
                    Console.WriteLine(x);
                }

                //Query syntax
                var Taken2 = (from x in arr where x < 6 select x).Take(2);
                foreach (var x in Taken2)
                {
                    Console.WriteLine(x);
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }


        //TakeWhile method
        public static void TakeWhile()
        {
            try
            {
                int[] arr = new int[] { 4, 6, 8, 9, 3, 7, 2 };

                //Method syntax
                var Taken = arr.TakeWhile((x => x > 4)).ToList();
                foreach (var x in Taken)
                {
                    Console.WriteLine(x);
                }

                //Query syntax
                var Taken2 = (from x in arr select x).TakeWhile(x => x < 6).ToList();
                foreach (var x in Taken2)
                {
                    Console.WriteLine(x);
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
