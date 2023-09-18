using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Define variables
            string myName, myExpectation, myLocation;

            Console.WriteLine();
            Console.WriteLine();
            //Input from user
            Console.Write("Please type your full name: ");
            myName = Console.ReadLine();


            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Kindly enter your location: ");
            myLocation = Console.ReadLine();


            Console.WriteLine();
            Console.WriteLine();
            Console.Write("What are your expectations this semester:");
            myExpectation = Console.ReadLine();


            Console.WriteLine();
            Console.WriteLine();
            //Get current date
            DateTime currentDate = DateTime.Now;
            Console.WriteLine(currentDate.ToString("dd/MM/yyyy"));

            //Date until christmas
            DateTime christmasDate = new DateTime(currentDate.Year, 12, 25);
            int daysToChristmas = (int)(christmasDate - currentDate).TotalDays;
            Console.WriteLine($"There are {daysToChristmas}days until Christmas this year.");

           


            double width, height, woodLength, glassArea;
            string widthString, heightString;

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Enter a specific width");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Enter a specific height");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);
            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("The length of the wood is " +
            woodLength + " feet");
            Console.WriteLine("The area of the glass is " +
            glassArea + " square metres");


            Console.ReadKey();
        }
    }
}
