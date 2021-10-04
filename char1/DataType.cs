using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace char1
{
    class Program
    {
        static void Main(string[] args)
        {
            // task1
            Console.WriteLine("Welcome to Money Maker!");
            Console.Write("Enter an amount to convert to coins: ");

            double amount = Math.Truncate(Convert.ToDouble(Console.ReadLine()));
            int goldValue = 10;
            int silverValue = 5;

            double goldCoins = (int)Math.Floor(amount / goldValue);
            double remainder = (amount % goldValue);

            double silverCoins = Math.Floor(remainder / silverValue);
            remainder = remainder % silverValue;

            Console.WriteLine("\n" + amount + " cents is equal to..." + "\n" + "Gold coins: " + goldCoins + "\n" +
                              "Silver coins: " + silverCoins + "\n" + "Bronze coins: " + remainder);

            Console.WriteLine($"\n{amount} cents is equal to \nGold coins: {goldCoins} \nSilver coins: {silverCoins} \nBronze coins: {remainder}");
            string end = Console.ReadLine();



            //task 2
            Console.Write("What is your name? ");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}! Welcome to our story.");
            Console.WriteLine("\nIt begins on a cold rainy night. You're sitting\nin your room and hear a noise coming from down\nthe hall. Do you go investigate?");
            Console.WriteLine("Now it's time to make a decision, what should you do?");
            Console.WriteLine("Enter  YES  or  NO");
            string noiseChoice = Console.ReadLine().ToUpper();
            if (noiseChoice == "YES")
            {
                Console.WriteLine("You walk into the hallway and see a light coming\nfrom under a door down the hall. You walk towards it.\nDo you open it or knock?\n");
                Console.WriteLine("Now it’s time for you to do another choice.");
                Console.WriteLine("Enter  OPEN  or  KNOCK");
                string doorchoice = Console.ReadLine().ToUpper();
                if (doorchoice == "KNOCK")
                {
                    Console.WriteLine("\nA voice behind the door speaks. It says, Answer this riddle: Poor people have it. Rich people need it. If you eat it you die. What is it?");
                    Console.WriteLine("Enter your answer: ");
                    string riddleAnswer = Console.ReadLine().ToUpper();
                    if (riddleAnswer == "NOTHING")
                    {
                        Console.WriteLine("\nThe door opens and NOTHING is there. You turn off the light and run back to your room and lock the door. THE END.");
                    }
                    else
                    {
                        Console.WriteLine("\nYou answered incorrectly. The door doesn't open. THE END.");
                    }
                }
                else if (doorchoice == "OPEN")
                {
                    Console.WriteLine("The door is locked! See if one of your three keys will open it.");
                    Console.WriteLine("Enter a number (1-3): ");
                    string keyChoice = Console.ReadLine().ToUpper();
                    switch (keyChoice)
                    {
                        case "1":
                            Console.WriteLine("You choose the first key. Lucky choice! The door opens and NOTHING is there. Strange...THE END.");
                            break;
                        case "2":
                            Console.WriteLine("You choose the second key. The door doesn't open. THE END");
                            break;
                        case "3":
                            Console.WriteLine("You choose the third key. The door doesn't open. THE END.");
                            break;
                        default:
                            Console.WriteLine("NOTHING is there.... THE END.");
                            break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Not much of an adventure if we don't leave our room! THE END.");
                string end1 = Console.ReadLine();
            }
        }
    }

}

