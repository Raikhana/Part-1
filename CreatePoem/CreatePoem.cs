using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatePoem
{
    class CreatePoem
    {
        static void Main(string[] args)
        {
            //Task 1
            //Initial tex
            string text = "algorithm - noun. A step by step procedure for calculations, special way of solving mathematical problem." +
                          "\n allocate - verb. allot or assign, to set apart for specific purpose.\n analogy - noun. Comparison, partial similarity." +
                          "\n anagram - noun. A word or phrase formed by rearranging the letters of another.anecdote, anomaly, appraise" +
                          "\n apposite - applicable, apron, fitting, typical adjective, articulate";
            Console.WriteLine($"\n\tInitial text:\t\n {text}");

            //Sorting words
            string[] summerStrut = text.Split(' ', ',', '.', ':', '-','\t');

            List<string> listOfWords = new List<string>();
            foreach (string word in summerStrut)
            {
                if (word.StartsWith("a"))
                {
                    listOfWords.Add(word);
                }
            }
            listOfWords.Reverse();
            Console.WriteLine("\n\n\tSorted words that start with the letter “a”:");
            printList(listOfWords);

            //generating poem
            Console.WriteLine("\n\tGenerated poem:");
            int wordsInSentence = listOfWords.Capacity / 4;
            for (int i = 0; i < wordsInSentence; i++)
            {
                List<string> sublist = listOfWords.GetRange(i*4, 4);
                sublist.Sort();
                printList(sublist);
            }
            Console.ReadLine();
        }
        //printing list of ords
        static void printList(List<string> list)
        {
            foreach (var i in list)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine(" \t\n");
        }
    }
}
