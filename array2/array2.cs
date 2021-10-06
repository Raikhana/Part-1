using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array2
{
    class array2
    {
        static void Main(string[] args)
        {
            //Initializing and storing value in arrays
            
            Console.Write("\nan array #1:\t");
            int[] arr1 = new int[5] { 43, 25, 33, 14, 10 };
            printarray(arr1);

            Console.Write("\nan array #2:\n");
            int[] arr2 = new int[6];
            int i;
            for (i = 0; i < 6; i++)
            {
                Console.Write("Enter number:\t");
                arr2[i] = Convert.ToInt32(Console.ReadLine());
            }
            printarray(arr2);

            //Sorting arrays
            Console.Write("\n\nSORTING an array #1:\t");
            Array.Sort(arr1);
            printarray(arr1);
            Console.WriteLine("Length:\t{0}", arr1.GetLength(0));
            Console.WriteLine("Value of 3 element:\t{0}", arr1.GetValue(2));
            Console.WriteLine("Index position of number 10:\t{0}", Array.IndexOf(arr1, 10));

            Console.Write("\n\nSORTING an array #2:\t");
            Array.Sort(arr2);
            printarray(arr2);
            Console.WriteLine("Length:\t{0}", arr2.GetLength(0));
            Console.WriteLine("Value of 3 element:\t{0}", arr2.GetValue(2));
            Console.WriteLine("Index position of number 10:\t{0}", Array.IndexOf(arr2, 10));

            //Copying
            Array.Copy(arr1, arr2, 3);
            Console.WriteLine("\n\nCOPYING arr1's 3 numbers to arr2");
            printarray(arr1);
            printarray(arr2);

            //Removing
            Console.WriteLine("\nREMOVING numbers from arrays:");
            Array.Clear(arr1, 0, 2);
            Array.Clear(arr2, 2, 4);
            Console.Write("an array 1:\t");
            printarray(arr1);
            Console.Write("an array 1:\t");
            printarray(arr2);
            Console.ReadLine();


        }
        //printing arrays
        static void printarray(int[] arr)
        {
            Console.WriteLine("\nElements of array is:\n");
            foreach (int i in arr)
            {
                Console.Write("\t{0}", i);
            }
            Console.WriteLine("\n");
        }
    }
}
