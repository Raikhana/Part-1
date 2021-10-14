using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsReview
{
    class LoopsReview
    {
        static void Main(string[] args)
        {
            //Task 2
            // an initial array of numbers  
            Console.WriteLine("\n\n\tAn initial array of numbers:");
            int[] arr = new int[12] { 49, 93, 85, 16, 111, 456, 9, 10, 55, 58, 60, 62, };
            printarray(arr);
            sortArry(arr);
            Console.ReadLine();
        }

        //Sorting numbers
        static bool sortArry(int[] arr)
        {
            List<int> list1 = new List<int>();
            List<int> list2 = new List<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    list1.Add(arr[i]);
                }
                else
                {
                    list2.Add(arr[i]);
                }
            }
            Console.WriteLine("list of even numbers:");
            printList(list1);
            Console.WriteLine("list of odd numbers:");
            printList(list2);
            return true;
        }

        //Printing arr of nunbers
        static void printarray(int[] arr)
        {
            Console.WriteLine("\nElements of array is:");
            foreach (int i in arr)
            {
                Console.Write("\t{0}", i);
            }
            Console.WriteLine("\n");
        }

        //Printing list of numbers
        static void printList(List<int> list)
        {
            foreach (int i in list)
            {
                Console.Write("\t{0}", i);
            }
            Console.WriteLine("\n");
        }
    }
}
