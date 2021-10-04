using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace char8
{
    class Order
    {
        static decimal discountPercent;
        static void Main(string[] args)
        {
            int subtotal;
            int price = 0;
            Console.WriteLine("START YOUR ORDER");
            Console.WriteLine($"\nYou will need to enter one type of product at separate times.\n");
            Console.WriteLine("What's it going to be?\n");
            Console.WriteLine("\tpizza / burger / salad");
            string product = Console.ReadLine();
            Console.WriteLine("\nWhat size would you like?\n ");
            Console.WriteLine("\tsmall / medium / large");
            string size = Console.ReadLine();
            Console.WriteLine("\nAmount of products: ");
            int amount = Convert.ToInt32(Console.ReadLine());

            if (product == "pizza")
            {
                if (size == "small")
                    price = 20;
                else if (size == "medium")
                    price = 25;
                else if (size == "large")
                    price = 30;
            }
            else if (product == "burger")
            {
                if (size == "small")
                    price = 15;
                else if (size == "medium")
                    price = 20;
                else if (size == "large")
                    price = 25;;
            }
            else
            {
                if (size == "small")
                    price = 10;
                else if (size == "medium")
                    price = 20;
                else if (size == "large")
                    price = 30;
            }

            subtotal = price * amount;
            Console.WriteLine($"\nTotal without discount: $ {subtotal.ToString()}");

            Console.WriteLine("\nWhat kind of coupons do you have?\n");
            Console.WriteLine("\tR / C / T");
            string coupon = Console.ReadLine();
            switch (coupon)
            {
                case "R":
                    if (subtotal >= 10 && subtotal < 25)
                        discountPercent = .0m;
                    else if (subtotal >= 25 && subtotal < 45)
                        discountPercent = .1m;
                    else if (subtotal >= 50 && subtotal < 75)
                        discountPercent = .25m;
                    break;
                case "C":
                    if (subtotal < 85)
                        discountPercent = .2m;
                    else
                        discountPercent = .3m;
                    break;
                case "T":
                    discountPercent = .4m;
                    break;
                default:
                    discountPercent = .0m;
                    break;
            }
            decimal discountAmount = subtotal * discountPercent;
            decimal total = subtotal - discountAmount;

            Console.WriteLine($"\nDiscount percent is: {discountPercent.ToString()}");
            Console.WriteLine($"Discount amount is: {discountAmount.ToString()}");
            Console.WriteLine($"Total is: $ {total.ToString()}");

            string product1 = Console.ReadLine();

        }            
    }
}
