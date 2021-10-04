using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace char3
{
    class DogYears
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program starts.");

            bool task1 = true;
            string result1 = task1.ToString();
            Console.WriteLine(result1);

            string task2 = "Pizza";
            char[] result2 = task2.ToCharArray();
            Console.WriteLine(result2);

            decimal task3 = 34.5m;
            float result3 = (float)task3;
            Console.WriteLine(result3);

            Console.WriteLine("Exit.");



            Console.WriteLine("     First Task");
            int myAge = 30;
            int equivalent = 7;
            double ageInDogYears = myAge / equivalent;
            Console.WriteLine(" My age in dog years: " + ageInDogYears + "\n");


            Console.WriteLine("     Second Task");
            int annualCompound = 12;  //monthly
            double principal = 3000;
            double interestRate = 6.50 / 100;
            int years = 3;

            double i = interestRate / annualCompound;
            int n = annualCompound * years;
            double ratePerPeriod = interestRate / years;
            double amountEarned = principal * Math.Pow(1 + i, n);
            double interestEarned = amountEarned - principal;

            Console.WriteLine("Annual compound = 12 months;" + "\n" + "Principal = 3000 $;" + "\n" + "Interest Rate = 6.50 %;" + "\n");
            Console.WriteLine("Your amount after " + years + " years:  " + Math.Round(amountEarned, 2) + " $");
            Console.WriteLine("You will earn Interest: " + Math.Round(interestEarned, 2) + " $");
        }
    }
}
