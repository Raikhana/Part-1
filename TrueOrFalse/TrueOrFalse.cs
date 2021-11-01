using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrueOrFalse
{
    class TrueOrFalse
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nWelcome to 'True or False?'\nPress Enter to begin:");
            string entry = Console.ReadLine();
            string[] questions = { "A type that is defined as a class is a reference type.", "A type that is defined as a class, record, delegate, array, or interface is a reference type." };
            bool[] answers = new bool[] { true, true };
            bool[] responses = new bool[2];

            if (questions.Length != answers.Length)
            {
                Console.WriteLine("Warning! That is not right! Try again!");
            }

            RunQuiz(questions, responses);

            int scoringIndex = 0;
            int score = 0;
            foreach (var a in answers)
            {
                bool b = responses[scoringIndex];
                Console.WriteLine($"{scoringIndex + 1}. Imput: {responses[scoringIndex]} | Answer: {a} \n");
                if (responses[scoringIndex] == answers[scoringIndex])
                {
                    score++;
                }
                scoringIndex++;
            }
            Console.WriteLine($" You got {score} out of {questions.Length} correct!");
            Console.ReadLine();
        }

        private static void RunQuiz(string[] questions, bool[] responses)
        {
            int askingIndex = 0;
            foreach (var q in questions)
            {
                string input = null;
                bool isBool = true;
                bool inputBool;
                Console.WriteLine(q);
                Console.WriteLine("True or false?");
                input = Console.ReadLine();
                isBool = Boolean.TryParse(input, out inputBool);
                while (isBool == false)
                {
                    Console.WriteLine("Please respond with 'true' or 'false'.");
                    input = Console.ReadLine();
                    isBool = Boolean.TryParse(input, out inputBool);
                }
                responses[askingIndex] = Convert.ToBoolean(input);
                askingIndex++;
            }
            string msgString = String.Join(", ", responses);
            Console.WriteLine($"\nThe values of responses: { msgString}\n");
        }
    }
}
