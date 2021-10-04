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
            string[] summerStrut;

            summerStrut = new string[] { "Juice", "Missing U", "Raspberry Beret", "New York Groove", "Make Me Feel", "Rebel Rebel", "Despacito", "Los Angeles", "New York Groove" };
            int[] ratings = { 5, 4, 4, 3, 3, 5, 5, 4 };
            if (summerStrut.Length == 8)
            {
                Console.WriteLine("summerStrut Playlist is ready to go!");
            }
            else if (summerStrut.Length > 8)
            {
                Console.WriteLine("Too many songs!");
            }
            Console.WriteLine($"You rated the song {summerStrut[1]} {ratings[1]} stars.");

            //find the position for the first 3-star rated song and save it to a variable.
            int ratePosition = Array.IndexOf(ratings, 3);
            Console.WriteLine($"Song number {ratePosition + 1} is rated three stars");

            // Find the first song that has more than 10 characters in its title./summerStrut
            string longestSong = Array.Find(summerStrut, height => height.Length > 10);
            Console.WriteLine("The first song that has more than 10 characters in the title is {0} ", longestSong);

            //the playlist alphabetically
            Array.Sort(summerStrut);
            Console.WriteLine(summerStrut[0] + " " + summerStrut[7]);

            summerStrut = new string[] { "Juice", "Missing U", "Raspberry Beret", "New York Groove", "Make Me Feel", "Rebel Rebel", "Despacito", "Los Angeles", "New York Groove" };
            string[] summerStrutCopy = { "New York Groove", "Missing U", "Raspberry Beret", "New York Groove", "Make Me Feel", "Rebel Rebel", "Despacito", "Los Angeles", "Missing U" };
            Array.Copy(summerStrut, summerStrutCopy, summerStrut.Length);
            Console.WriteLine(summerStrutCopy[0]);

            Array.Reverse(summerStrut);
            Console.WriteLine(summerStrut[0] + " " + summerStrut[7]);
            Console.ReadLine();

            summerStrut = new string[] { "Juice", "Missing U", "Raspberry Beret", "New York Groove", "Make Me Feel", "Rebel Rebel", "Despacito", "Los Angeles", "New York Groove" };
            Array.Clear(ratings, 0,  7);
            Console.WriteLine(ratings[0]);
            Console.ReadKey();
        }
    }
}
