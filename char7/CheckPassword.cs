using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace char7
{
    class CheckPassword
    {
        static void Main(string[] args)
        {
            //task 1 
            Console.WriteLine("\nEnter password");
            Console.WriteLine($"\n\t*Password  must contain at least: a number, one upper case letter, and 8 characters.");

            string input = Console.ReadLine();
            var number = new Regex(@"[0-9]+");
            var uppercaseLetters = new Regex(@"[A-Z]+");
            var minimun8Character = new Regex(@"^.{8,9}$");

            var checksPassword = number.IsMatch(input) && uppercaseLetters.IsMatch(input)
                                                   && minimun8Character.IsMatch(input);

            string result = checksPassword ? "\nPassword is correct." : "\nPassword is incorrect";
            Console.WriteLine(result);
            string end = Console.ReadLine();

            // task 2
            Console.WriteLine("'Movie recommender' advises the movie in a particular genre.\n Please, select a genre.\n" +
                              " Drama\n Comedy\n Adventure\n Horror\n Science Fiction\n");
            string genre = Console.ReadLine();
            switch (genre)
            {
                case "Drama":
                    Console.WriteLine("Citizen Kane");
                    break;
                case "Comedy":
                    Console.WriteLine("Duck Soup");
                    break;
                case "Adventure":
                    Console.WriteLine("King Kong");
                    break;
                case "Horror":
                    Console.WriteLine("Psycho");
                    break;
                case "Science Fiction":
                    Console.WriteLine("2001: A Space Odyssey");
                    break;
                default:
                    Console.WriteLine("No movie found");
                    break;
            }
            //var hasNumber = new Regex(@"[0-9]+");
            //var hasUpperChar = new Regex(@"[A-Z]+");
            //var hasMinimum8Chars = new Regex(@".{8,15}"); // (@"^.{8,9}$");
            //var hasLowerChar = new Regex(@"[a-z]+");
            //var hasSymbols = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");

           
        }
    }
}
