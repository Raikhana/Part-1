using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace char9
{
    class Password
    {
        static int minLength = 8;
        static string uppercase = "QWE";
        static string lowercase = "asd";
        static string digits = "6";
        static string specialChars = "?!";

        static void Main(string[] args)
        {
            Console.WriteLine("enter a password");
            string password = Console.ReadLine();
            int score = 0;
            
            if ( password.Contains("1234") || password.Contains("password"))
            {
                //score--;
                Console.WriteLine($"\nThe score is: 0 ");
                Console.WriteLine("The password doesn’t meet any of the standards");
            }
            else
            {
                if (password.Length >= minLength)
                {
                    score++;
                }
                if (password.Contains(uppercase))
                {
                    score++;
                }
                if (password.Contains(lowercase))
                {
                    score++;
                }
                if (password.Contains(digits))
                {
                    score++;
                }
                if (password.Contains(specialChars))
                {
                    score++;
                }
            }
            Console.WriteLine($"\nThe score is: {score}");
            

            switch (score)
            {
                case 5:
                    Console.WriteLine("The password is extremely strong");
                    break;
                case 4:
                    Console.WriteLine("The password is extremely strong");
                    break;
                case 3:
                    Console.WriteLine("The password is strong");
                    break;
                case 2:
                    Console.WriteLine("The password is medium");
                    break;
                case 1:
                    Console.WriteLine("The password is weak");
                    break;
                default:
                    Console.WriteLine("The password doesn’t meet any of the standards");
                    break;
            }
            string password1 = Console.ReadLine();


        }
    }
}
