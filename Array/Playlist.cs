using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace array
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] summerStrut;

            //summerStrut = new string[] { "Juice", "Missing U", "Raspberry Beret", "New York Groove", "Make Me Feel", "Rebel Rebel", "Despacito", "Los Angeles", "New York Groove" };
            //int[] ratings = { 5, 4, 4, 3, 3, 5, 5, 4 };
            //if (summerStrut.Length == 8)
            //{
            //    Console.WriteLine("summerStrut Playlist is ready to go!");
            //}
            //else if (summerStrut.Length > 8)
            //{
            //    Console.WriteLine("Too many songs!");
            //}
            //Console.WriteLine($"You rated the song {summerStrut[1]} {ratings[1]} stars.");

            ////find the position for the first 3-star rated song and save it to a variable.
            //int ratePosition = Array.IndexOf(ratings, 3);
            //Console.WriteLine($"Song number {ratePosition + 1} is rated three stars");

            //// Find the first song that has more than 10 characters in its title./summerStrut
            //string longestSong = Array.Find(summerStrut, height => height.Length > 10);
            //Console.WriteLine("The first song that has more than 10 characters in the title is {0} ", longestSong);

            ////the playlist alphabetically
            //Array.Sort(summerStrut);
            //Console.WriteLine(summerStrut[0] + " " + summerStrut[7]);

            //summerStrut = new string[] { "Juice", "Missing U", "Raspberry Beret", "New York Groove", "Make Me Feel", "Rebel Rebel", "Despacito", "Los Angeles", "New York Groove" };
            //string[] summerStrutCopy = { "New York Groove", "Missing U", "Raspberry Beret", "New York Groove", "Make Me Feel", "Rebel Rebel", "Despacito", "Los Angeles", "Missing U" };
            //Array.Copy(summerStrut, summerStrutCopy, summerStrut.Length);
            //Console.WriteLine(summerStrutCopy[0]);

            //Array.Reverse(summerStrut);
            //Console.WriteLine(summerStrut[0] + " " + summerStrut[7]);
            //Console.ReadLine();

            //summerStrut = new string[] { "Juice", "Missing U", "Raspberry Beret", "New York Groove", "Make Me Feel", "Rebel Rebel", "Despacito", "Los Angeles", "New York Groove" };
            //Array.Clear(ratings, 0,  7);
            //Console.WriteLine(ratings[0]);
            //Console.ReadKey();



            //Initializing and storing value in arr1
            int[] arr1 = new int[5] { 43, 25, 33, 14, 5 };
            int[] arr2 = new int[5];

            //Sorting an array
            Array.Sort(arr1);
            printarray(arr1);

            //Returning Lenght from specified position
            Console.WriteLine("Get Length:\t{0}", arr1.GetLength(0));

            //Returns value of specied position
            Console.WriteLine("Get Value:\t{0}", arr1.GetValue(2));

            //Returns Index position of specified value
            Console.WriteLine("Get Index:\t{0}", Array.IndexOf(arr1, 33));

            //Copying arr1's items to arr2
            Array.Copy(arr1, arr2, 5);
            printarray(arr2);

            //Removing items from array.
            Array.Clear(arr1, 0, 5);
            printarray(arr1);

            Console.ReadLine();




            // Use this input array.
            int[] array = { 5, 6, 7, 6 };

            // Use FindIndex method with predicate.
            int index1 = Array.FindIndex(array, item => item == 6);
            // Use LastFindIndex method with predicate.
            int index2 = Array.FindLastIndex(array, item => item == 6);

            // Write results.
            Console.WriteLine("{0} = {1}", index1, array[index1]);
            Console.WriteLine("{0} = {1}", index2, array[index2]);


        }
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
