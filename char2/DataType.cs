using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza
{
    class DataType
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n        Please, explore the menu categories. We have pizza, salad, burgers. \n\n" +
                              "  Select a menu category: \n" +
                              "  enter Pizza \n" +
                              "  enter Salad \n" +
                              "  enter Burger \n");
            string category = Console.ReadLine();
            char[] categoryChar = category.ToCharArray();

            Console.WriteLine("  Please, select a size: \n" +
                              "  enter Regular \n" +
                              "  enter Large \n");
            string size = Console.ReadLine();
            char[] sizeChar = size.ToCharArray();

            Console.WriteLine("  How many plates do you want? \n" +
                              "  Please, enter a digit between 1 to 7. \n");
            string digit = Console.ReadLine();
            int d = Convert.ToInt32(digit);

            Console.WriteLine("Your an order is:  " + d);
            Console.WriteLine(sizeChar);
            Console.WriteLine(categoryChar);
            Console.WriteLine("Please, enter " + "yes" + " if order is correct and " + "no" + " if not");
            string correct = Console.ReadLine();

            if (correct == "yes")
            {
                Console.WriteLine("Plese, pay now");
            }
            else if (correct == "no")
            {
                Console.WriteLine("Start again");
            }
            else
            {
                Console.WriteLine("input incorrect");
            }
            string end = Console.ReadLine();
        }
    }
}
