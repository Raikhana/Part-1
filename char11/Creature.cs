using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace char11
{
    class Creature
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\tGame: 'Build an unknown creature'");

            Console.WriteLine("\n\tWould you like to see creatures like monsters, bugs or ghosts?");
            string answer = Console.ReadLine();
            if (answer == "yes")
            {
                Console.WriteLine("\tghost");
                BuildACreature("ghost", "ghost", "ghost");

                Console.WriteLine("\n\tmonster");
                BuildACreature("monster", "monster", "monster");

                Console.WriteLine("\n\tbug");
                BuildACreature("bug", "bug", "bug");

                Console.WriteLine("\nAlso, we have automated the process of building a random creature.\n");
                RandomMode();

                Console.WriteLine("\n\tPlay Game: 'Build an unknown creature'");
                Console.WriteLine("\n Swap out the different creatures and create lots of different character combinations..");
                Console.WriteLine(" Draw either a head, body, or feet of a creature.\n");
                Console.WriteLine(" For a 'head' select between:  ghost, monster or bug");
                string headStr = Console.ReadLine();
                Console.WriteLine(" For a 'body' select between:  ghost, monster or bug");
                string bodyStr = Console.ReadLine();
                Console.WriteLine(" For a 'feet' select between:  ghost, monster or bug");
                string feetStr = Console.ReadLine();
                Console.WriteLine("\n\tThe drawing is finished!");
                BuildACreature(headStr, bodyStr, feetStr);

                Console.WriteLine("\n\tLet's try a different creature!");
                Console.WriteLine(" For a 'head' select between:  ghost, monster or bug");
                string headStr1 = Console.ReadLine();
                Console.WriteLine(" For a 'body' select between:  ghost, monster or bug");
                string bodyStr1 = Console.ReadLine();
                Console.WriteLine(" For a 'feet' select between:  ghost, monster or bug");
                string feetStr1 = Console.ReadLine();
                int headNum = TranslateToNumber(headStr1);
                int bodyNum = TranslateToNumber(bodyStr1);
                int feetNum = TranslateToNumber(feetStr1);
                SwitchCase(headNum, bodyNum, feetNum);
                Console.WriteLine("\n\tCongratulations, you build your creature practicing the switch method!");

                Console.WriteLine("\n\tLet's try to create another creature!");
                Console.WriteLine("\tIn this case, we will assign a random 'body' part if you will not name or skip a part of the creature.");
                Console.WriteLine(" For a 'head' select between:  ghost, monster, bug or skip this part");
                string headStr2 = Console.ReadLine();
                Console.WriteLine(" For a 'body' select between:  ghost, monster, bug or skip this part");
                string bodyStr2 = Console.ReadLine();
                Console.WriteLine(" For a 'feet' select between:  ghost, monster, bug or skip this part");
                string feetStr2 = Console.ReadLine();
                BuildACreature(headStr2, bodyStr2, feetStr2);

                Console.WriteLine("\n\tGood job,  we work together!");
                Console.WriteLine("\n\tWe've finished our rounds.\n\tThanks a lots");
                string input = Console.ReadLine();
            }
            else if(answer == "no")
            {
                Console.WriteLine("The final point of the game.\nEnd");
                string end = Console.ReadLine();

            }
            else
            {
                Console.WriteLine("You did not answer the question. End");
                string end = Console.ReadLine();
            }
        }

        //BuildACreature() combines calling three methods for each part of the body
        static void BuildACreature(string head, string body, string feet)
        {
            System.Random randomNumber = new System.Random();
            if (head == "") 
            {
                int head1 = randomNumber.Next(1, 4);
                SwitchHead(head1);
                switch (body)
                {
                    case "ghost":
                        GhostBody();
                        break;
                    case "bug":
                        BugBody();
                        break;
                    case "monster":
                        MonsterBody();
                        break;
                    default:
                        GhostBody();
                        break;
                }
                switch (feet)
                {
                    case "ghost":
                        GhostFeet();
                        break;
                    case "bug":
                        BugFeet();
                        break;
                    case "monster":
                        MonsterFeet();
                        break;
                    default:
                        GhostFeet();
                        break;
                }
            }
            else if(body == "")
            {
                switch (head)
                {
                    case "ghost":
                        GhostHead();
                        break;
                    case "bug":
                        BugHead();
                        break;
                    case "monster":
                        MonsterHead();
                        break;
                    default:
                        GhostHead();
                        break;
                }
                int body1 = randomNumber.Next(1, 4);
                SwitchBody(body1);
                switch (feet)
                {
                    case "ghost":
                        GhostFeet();
                        break;
                    case "bug":
                        BugFeet();
                        break;
                    case "monster":
                        MonsterFeet();
                        break;
                    default:
                        GhostFeet();
                        break;
                }
            }
            else if(feet == "")
            {
                switch (head)
                {
                    case "ghost":
                        GhostHead();
                        break;
                    case "bug":
                        BugHead();
                        break;
                    case "monster":
                        MonsterHead();
                        break;
                    default:
                        GhostHead();
                        break;
                }
                switch (body)
                {
                    case "ghost":
                        GhostBody();
                        break;
                    case "bug":
                        BugBody();
                        break;
                    case "monster":
                        MonsterBody();
                        break;
                    default:
                        GhostBody();
                        break;
                }
                int feet1 = randomNumber.Next(1, 4);
                SwitchFeet(feet1);
            }
            else
            {
                switch (head)
                {
                    case "ghost":
                        GhostHead();
                        break;
                    case "bug":
                        BugHead();
                        break;
                    case "monster":
                        MonsterHead();
                        break;
                    default:
                        GhostHead();
                        Console.WriteLine("\t\t*you didn't name this part of the creature's body, we insert the missing part.");
                        break;
                }
                switch (body)
                {
                    case "ghost":
                        GhostBody();
                        break;
                    case "bug":
                        BugBody();
                        break;
                    case "monster":
                        MonsterBody();
                        break;
                    default:
                        GhostBody();
                        Console.WriteLine("\t\t*you didn't name this part of the creature's body, we insert the missing part.");
                        break;
                }
                switch (feet)
                {
                    case "ghost":
                        GhostFeet();
                        break;
                    case "bug":
                        BugFeet();
                        break;
                    case "monster":
                        MonsterFeet();
                        break;
                    default:
                        GhostFeet();
                        Console.WriteLine("\t\t*you didn't name this part of the creature's body, we insert the missing part.");
                        break;
                }
            }
        }

        // method of building a random creature
        static void RandomMode()
        {
            System.Random randomNumber = new System.Random();
            int head = randomNumber.Next(1, 4);
            int body = randomNumber.Next(1, 4);
            int feet = randomNumber.Next(1, 4);
            SwitchCase(head, body, feet);
        }

        //SwitchCase() prints a complete creature to the console
        static void SwitchCase(int head, int body, int feet)
        {
            switch (head)
            {
                case 1:
                    GhostHead();
                    break;
                case 2:
                    BugHead();
                    break;
                case 3:
                    MonsterHead();
                    break;
                default:
                    Console.WriteLine("No creatures found");
                    break;
            }
            switch (body)
            {
                case 1:
                    GhostBody();
                    break;
                case 2:
                    BugBody();
                    break;
                case 3:
                    MonsterBody();
                    break;
                default:
                    Console.WriteLine("No creatures found");
                    break;
            }
            switch (feet)
            {
                case 1:
                    GhostFeet();
                    break;
                case 2:
                    BugFeet();
                    break;
                case 3:
                    MonsterFeet();
                    break;
                default:
                    Console.WriteLine("No creatures found");
                    break;
            }
        }
        // the method  takes in a creature name and translates it to an int that SwitchCase() can make sense of
        static int TranslateToNumber(string creature)
        {
            switch (creature)
            {
                case "ghost":
                    return 1;

                case "bug":
                    return 2;

                case "monster":
                    return 3;

                default:
                    Console.WriteLine("\t\t*you didn't name some part of the creature's body, we insert the missing part.");
                    return 1;
            }
        }

        //method assign a random body part if a parameter is not specified ( for example:  if(body == "") ) called in BuildACreature method
        static void SwitchHead(int head)
        {
            switch (head)
            {
                case 1:
                    GhostHead();
                    break;
                case 2:
                    BugHead();
                    break;
                case 3:
                    MonsterHead();
                    break;
                default:
                    Console.WriteLine("No creatures found");
                    break;
            }
        }
        // method assign a random body part if a parameter is not specified( for example:  if(body == "") )called in BuildACreature method
        static void SwitchBody(int body)// 
        {
            switch (body)
            {
                case 1:
                    GhostBody();
                    break;
                case 2:
                    BugBody();
                    break;
                case 3:
                    MonsterBody();
                    break;
                default:
                    Console.WriteLine("No creatures found");
                    break;
            }
        }
        //method assign a random body part if a parameter is not specified ( for example:  if(body == "") )called in BuildACreature method
        static void SwitchFeet(int feet)   
        {
            switch (feet)
            {
                case 1:
                    GhostFeet();
                    break;
                case 2:
                    BugFeet();
                    break;
                case 3:
                    MonsterFeet();
                    break;
                default:
                    Console.WriteLine("No creatures found");
                    break;
            }
        }

        // nine methods that represent parts of the creature's body
        static void GhostHead()
        {
            Console.WriteLine("     ..-..");
            Console.WriteLine("    ( o o )");
            Console.WriteLine("    |  O  |");
        }

        static void GhostBody()
        {
            Console.WriteLine("    |     |");
            Console.WriteLine("    |     |");
            Console.WriteLine("    |     |");
        }

        static void GhostFeet()
        {
            Console.WriteLine("    |     |");
            Console.WriteLine("    |     |");
            Console.WriteLine("    '~~~~~'");
        }

        static void BugHead()
        {
            Console.WriteLine("     /   \\");
            Console.WriteLine("     \\. ./");
            Console.WriteLine("    (o + o)");
        }

        static void BugBody()
        {
            Console.WriteLine("  --|  |  |--");
            Console.WriteLine("  --|  |  |--");
            Console.WriteLine("  --|  |  |--");
        }

        static void BugFeet()
        {
            Console.WriteLine("     v   v");
            Console.WriteLine("     *****");
        }

        static void MonsterHead()
        {
            Console.WriteLine("     _____");
            Console.WriteLine(" .-,;='';_),-.");
            Console.WriteLine("  \\_\\(),()/_/");
            Console.WriteLine("　  (,___,)");
        }

        static void MonsterBody()
        {
            Console.WriteLine("   ,-/`~`\\-,___");
            Console.WriteLine("  / /).:.('--._)");
            Console.WriteLine(" {_[ (_,_)");
        }

        static void MonsterFeet()
        {
            Console.WriteLine("    |  Y  |");
            Console.WriteLine("   /   |   \\");
            Console.WriteLine("   \"\"\"\" \"\"\"\"");
        }
    }
}
