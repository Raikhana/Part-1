using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace char6
{
    class WordGame
    {
        //private static string EnteredWord;
        static string name;
        static string adjictiveFirst;
        static string adjictiveSecond;
        static string adjictiveThird;
        static string verb;
        static string firstNoun;
        static string secondNoun;
        static string animal;
        static string food;
        static string fruit;
        static string superhero;
        static string country;
        static string dessert;
        static string year;

        static void Main(string[] args)
        {
            Console.WriteLine("\t" + 3 + "\n" + "\t\t" + 2 + "\n" + "\t\t\t" + 1);
            Console.WriteLine("\t\t\t\tLet's get started a word game: \n");
            // Give the Mad Lib a title:
            string title = " CONVERSION";
            Console.WriteLine("\t\t\t\t\t" + title);

            // Define user input and variables:
            Console.Write("\nEnter a name:\t");
            name = CheckEmptyInput(Console.ReadLine());

            Console.WriteLine($"\nYou will need to enter three adjectives, one verb and two nouns at separate times.\n");
            Console.Write("Please, enter the first adjective -\t");
            adjictiveFirst = CheckEmptyInput(Console.ReadLine());

            Console.Write("Please, enter the second adjective -\t");
            adjictiveSecond = CheckEmptyInput(Console.ReadLine());

            Console.Write("Please, enter the third adjective -\t");
            adjictiveThird = CheckEmptyInput(Console.ReadLine());

            Console.Write("Please, enter one verb -\t\t");
            verb = CheckEmptyInput(Console.ReadLine());

            Console.Write("Please, enter the first noun -\t\t");
            firstNoun = CheckEmptyInput(Console.ReadLine());

            Console.Write("Please, enter the second noun -\t\t");
            secondNoun = CheckEmptyInput(Console.ReadLine());

            Console.WriteLine($"\nNow is a quick quiz of seven questions.\n" + "Please, enter one of each of the following:\n");
            Console.Write("An animal -\t");
            animal = CheckEmptyInput(Console.ReadLine());

            Console.Write("A food -\t");
            food = CheckEmptyInput(Console.ReadLine());

            Console.Write("A fruit -\t");
            fruit = CheckEmptyInput(Console.ReadLine());

            Console.Write("A superhero -\t");
            superhero = CheckEmptyInput(Console.ReadLine());

            Console.Write("A country -\t");
            country = CheckEmptyInput(Console.ReadLine());

            Console.Write("A dessert -\t");
            dessert = CheckEmptyInput(Console.ReadLine());

            Console.Write("A year -\t");
            year = CheckEmptyInput(Console.ReadLine());


            string story = $"\n This morning {name} woke up feeling {adjictiveFirst}. 'It is going to be a {adjictiveSecond} day!'\n\n " +
                           $"Outside, a bunch of {animal}s were protesting to keep {food} in stores.\n\n " +
                           $"They began to {verb} to the rhythm of the {firstNoun}, which made all the {fruit}s very {adjictiveThird}.\n\n " +
                           $"Concerned, {name} texted {superhero},who flew {name} to {country} and dropped {name} in a puddle of frozen {dessert}.\n\n" +
                           $" {name} woke up in the year {year},in a world where {secondNoun}s ruled the world.";

            Console.WriteLine("\n Great job!" + " Now we have all the words that needed for the story. " + "\n" +
                              " The end result is a really hilarious and strange story.\n");
            Console.WriteLine("\t\t\t\t\t" + " STORY ");
            Console.WriteLine(story);
            string year1 = Console.ReadLine();
        }
        private static string CheckEmptyInput(string EnterText)
        {
            string enteredVal = EnterText;
            if (string.IsNullOrWhiteSpace(enteredVal))
            {
                Console.WriteLine("Empty value not allowed.");
                Console.Write("Please, enter- " + "\n");
                enteredVal = Console.ReadLine();
            }
            if (!string.IsNullOrWhiteSpace(enteredVal))
            {
            }
            return enteredVal;

        }
    }
}
