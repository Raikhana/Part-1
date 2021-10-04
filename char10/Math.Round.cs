using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace char10
{
    class Program
    {
        static void Main(string[] args)
        {
            //calculating the material cost for a floor plan for the Pantheon in Rome
            double length = 2500, width = 1500, radius = 375, bottom = 750, height = 500, material = 180;
            
            Console.WriteLine("The program calculated the material cost for a floor plan for the Pantheon in Rome, Italy.\n");
            double areaRectangle = Rectangle(length, width);
            double areaCircle = Circle(radius);
            double areaTriangle = Triangle(bottom, height);
            double totalAreaPantheon = Math.Round(areaRectangle + areaTriangle + (areaCircle / 2), 5);
            double costOfFloorintMaterial = Math.Round(totalAreaPantheon * material, 2);

            Console.WriteLine($"The rectangular segment of the floor plan: {areaRectangle}m");
            Console.WriteLine($"The circle segment of the floor plan: {areaCircle}m");
            Console.WriteLine($"The triangle segment of the floor plan: {areaTriangle}m");
            Console.WriteLine($"The total area of the floor plan: {totalAreaPantheon}m");
            Console.WriteLine($"The cost of flooring material for the Teotihuacan monument costs {costOfFloorintMaterial} pesos");

            //calculating the material cost for a floor plan for the Taj Mahal in Agra, India and the Al-Masjid al-haram (Great Mosque) in Mecca, Saudi Arabia.
            Console.WriteLine("\nWhat monument would you like to work with?\n Please enter correct number\n 1 for:  The Taj Mahal in Agra, India\n 2 for:  The Al-Masjid al-haram(Great Mosque) in Mecca, Saudi Arabia.");
            string input = Console.ReadLine();

            double totalAreaTajMahal = (90.5 * 90.5) - ((0.5 * 24 * 24) * 4);
            double totalAreaGreatMosque = (180 * 106) + ((284 * 264) - (84 * 264 * 0.5));
            if (input == "1")
            {
                double cost = CalculateTotalCost(material, totalAreaTajMahal);
                Console.WriteLine($"The cost of flooring material for the Taj Mahal monument costs: {cost} rupee.");

            }
            else if(input == "2")
            {
                double cost = CalculateTotalCost(material, totalAreaGreatMosque);
                Console.WriteLine($"The cost of flooring material for the Great Mosqu monument costs: {cost} riyal.");
            }
            string end = Console.ReadLine();

        }
        //methods that calculate areas of the floor plan (Taj Mahal and Great Mosqu )
        static double CalculateTotalCost(double material, double area)
        {
            double costOfFloorintMaterial = Math.Round(area * material, 4);
            return costOfFloorintMaterial;
        }


        //methods that calculate areas of the floor plan for the Pantheon in Rome, Italy. 
        static double Rectangle(double length, double width)
        {
            double areaRectangle = length * width;
            return areaRectangle;
        }
        static double Circle(double radius)
        {
            double pi = Math.PI;
            double areaCircle = Math.Round(pi * Math.Pow(radius, 2), 5);
            return areaCircle;
        }
        static double Triangle(double bottom, double height)
        {
            double areaTriangle = 0.5 * bottom * height;
            return areaTriangle;
        }
        
    }
}
