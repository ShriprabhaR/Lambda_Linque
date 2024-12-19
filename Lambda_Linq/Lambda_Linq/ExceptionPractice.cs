using System;
using System.Collections.Generic;
using System.Text;

namespace Lambda_Linq
{
    internal class ExceptionPractice
    {
        public static void Display()
        {
            int[] arr = { 20, 16, 50, 30 };
            
            try
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine(arr[7]);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An exception occured: " + ex.Message);
            }
        }
    }
}
