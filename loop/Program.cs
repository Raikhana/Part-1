using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loop
{
    class Program
    {
        static void Main(string[] args)
        {
            //1

            //int emails = 20;
            //while (emails >= 0)
            //{
            //    Console.WriteLine($"emails are left: {emails}");
            //    emails--;
            //}
            //Console.WriteLine("INBOX ZERO ACHIEVED!");
            //Console.ReadKey();



            //2
            //string str = "";
            //bool buttonClick = true;
            //do
            //{
            //    Console.WriteLine("BLARRRRRRRRR [stop] [no] :");
            //    str = Console.ReadLine();
            //} while (!buttonClick || str != "stop");



            //3
            //string ans;
            //do
            //{
            //    Console.Write("Are you done? [yes] [no] : ");
            //    ans = Console.ReadLine();
            //} while (ans != "yes");




            //4
            //for (int i = 1; i < 17; i++)
            //{
            //    CreateTemplate(i);
            //}
            //Console.ReadKey();

            ////5
            //string[] todo = { "respond to email", "make wireframe", "program feature", "fix bugs" };
            //foreach (string task in todo)
            //{
            //    CreateTodoItem(task);
            //}
            //Console.ReadKey();



            string[] websites = { "twitter", "facebook", "gmail" };
            int counter = 0;

            while (counter < websites.Length)
            {
                Console.WriteLine(websites[counter]);
                counter++;
            }
            Console.ReadLine();

            string[] melody = { "a", "b", "c", "c", "b" };

            foreach (string note in melody)
            {
                //PlayMusic(note);
                Console.WriteLine($"[] {note}");
            }
            Console.ReadLine();

           


        }
        // for 4
        static void CreateTemplate(int week)
        {
            Console.WriteLine($"Week {week}");
            Console.WriteLine("Announcements: \n \n \n ");
            Console.WriteLine("Report Backs: \n \n \n");
            Console.WriteLine("Discussion Items: \n \n \n");
        }
        //for 5
        static void CreateTodoItem(string item)
        {
            Console.WriteLine($"[] {item}");
        }



    }
}
