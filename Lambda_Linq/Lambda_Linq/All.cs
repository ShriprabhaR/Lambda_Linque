using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lambda_Linq
{
    internal class All
    {
     
        public static void Display()
        {
            try
            {
                int[] arr = { 4, 16, 72, 31 };

                var MethSyntax = arr.All(x => x % 2 == 0 );
                if (MethSyntax)
                {
                    Console.WriteLine(MethSyntax + " All are even numbers");
                }
                else
                {
                    Console.WriteLine("Odd numbers are present");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        
        }
    }
}
