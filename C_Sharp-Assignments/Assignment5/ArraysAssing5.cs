using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class Class1
    {
        static void Main()
        {
            //C# program to illustrate the use of Array.sort<T>(T[]) method
            //creating a 1d array 
            string[] arr = new string[5] { "A", "G", "D", "K", "B" };

            //printing arrays before sort
            foreach(string x in arr)
            {
                Console.Write(" {0} ", x);
            }
            Console.WriteLine();
            Console.WriteLine("After Sorting array will look like");
            Array.Sort(arr);

            //printing arrays after sorting
            foreach(string x in arr)
            {
                Console.Write(" {0} ", x);
            }
            Console.WriteLine();
            Console.WriteLine("Sorted array");

            Console.Write("Enter string to check where it sorts between : ");
            string str = Console.ReadLine();
            Console.WriteLine();
            int index = Array.BinarySearch(arr, str);
            Console.WriteLine("Index of search element: {0}",index);

            //Calling a "SortT" function
            //which is SortT<<T>(T[]) function
            SortT(arr, index);
            Console.ReadLine();
        }

        static void SortT<T>(T[] arr,int index)
        {
            //
            if (index < 0)
                index = ~index;

            if (index == 0)
                Console.WriteLine("at the beginning of tha array");
            else
                Console.Write("{0} and ", arr[index - 1]);

            if (index == arr.Length)
                Console.WriteLine("at the end of array");
            else
                Console.WriteLine("{0} ", arr[index]);
        }
    }
}
