using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Sarah Parsons";
            string location = "Arizona";

            Console.WriteLine("My name is " + name + ", I am from " + location + ".");
            DateTime todaysDate = DateTime.Now;
            Console.WriteLine(todaysDate.ToString("MM/dd/yyyy"));

            DateTime daysLeft = DateTime.Parse("12/25/2020");

            TimeSpan t = daysLeft - todaysDate;

            Console.WriteLine("Days Until Christmas: " + t.Days);


            double width, height, woodLength, glassArea; string widthString, heightString;
            Console.WriteLine("\nWindow Calculator\nPlease enter the width: ");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);

            Console.WriteLine("Please  enter the height: ");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);

            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);

            Console.WriteLine("The length of the wood is " + woodLength + " feet");
            Console.WriteLine("The area of the glass is " + glassArea + " square metres");
            Console.ReadKey();
        }
    }
}
