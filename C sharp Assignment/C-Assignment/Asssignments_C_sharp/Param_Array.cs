using System;
using System.Collections.Generic;

namespace Asssignments_C_sharp
{
    class Param_Array
    {
        public static int Add_Arrays(params int[] ListNumbers)
        {
            int total = 0;
            
            foreach (int i in ListNumbers)
            {
                total += i;
            }
            return total;
        }
        public static void Main()
        {
            int arr = Add_Arrays(10, 20, 30, 40, 50);
            Console.WriteLine("Total Sum of array : {0}",arr);
        }
    }
}
