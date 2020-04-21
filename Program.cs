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
            string name = "Justin Lilly";
            string location = "Gilbert, Arizona";
            Console.WriteLine($"My name is {name}, I am from {location}.");

            // Days till Christmas
            DateTime today = DateTime.Today;
            DateTime christmas = new DateTime(2019, 12, 25);

            if (today.Year > christmas.Year) { christmas = christmas.AddYears(1); }
            TimeSpan interval = christmas - today;
            Console.Write("Today is " + DateTime.Now.ToString("yyyy-MM-dd") + ". ");
            Console.WriteLine("There are " + interval.Days + " days until Christmas.");

            // Book program example
            double width, height, woodLength, glassArea;
            string widthString, heightString;

            Console.WriteLine("Please enter the width of the wood: ");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);

            Console.WriteLine("Please enter the height of the wood: ");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);

            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);

            Console.WriteLine("The length of the wood is " + woodLength + " feet");
            Console.WriteLine("The area of the glass is " + glassArea + " square metres");

            // Keeps the console open until the user hits a button
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
