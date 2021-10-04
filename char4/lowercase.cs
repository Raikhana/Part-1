using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace char4
{
    class lowercase
    {
        static void Main(string[] args)
        {
            Console.WriteLine("       Task 1  \n ");
            string originalString = "Write a program that randomly converts part of a text to uppercase and lowercase to look like randomcase.";
            Console.WriteLine($"Original: \n {originalString} \n");
            string randomcase = null;
            var rand = new Random();
            foreach (char c in originalString)
            {
                int random = rand.Next(0, 2);
                if (random == 0)
                {
                    string x = c.ToString();
                    randomcase += x.ToLower();
                }
                else if (random == 1)
                {
                    string x = c.ToString();
                    randomcase += x.ToUpper();
                }
            }
            Console.WriteLine("Randomcase: \n " + randomcase + "\n\n");



            Console.WriteLine("       Task 2  \n ");
            string[] originalText = { "Write", "a", "program", "that", "takes", "in", "a", "series", "of", "random", "words", "to", "construct", "an", "automated", "poem", "in", "the", "style", "of", "e.e.cummings" };
            Console.WriteLine("Original text: ");
            Console.WriteLine(string.Join(" ", originalText) + "\n");

            for (int i = originalText.Length - 1; i >= 1; i--)
            {
                int j = rand.Next(i + 1);
                string poem = originalText[j];
                originalText[j] = originalText[i];
                originalText[i] = poem;
            }
            Console.WriteLine("Automated poem: \n ");
            Console.WriteLine(string.Join(" ", originalText[2], originalText[3], originalText[4], originalText[5], originalText[6]));
            Console.WriteLine(string.Join(" ", originalText[7], originalText[8], originalText[9], originalText[10], originalText[11]));
            Console.WriteLine(string.Join(" ", originalText[12], originalText[13], originalText[14], originalText[15], originalText[16]));
            Console.WriteLine(string.Join(" ", originalText[17], originalText[18], originalText[19], originalText[20], originalText[1])); 
            string end = Console.ReadLine();
        }
    }
}
