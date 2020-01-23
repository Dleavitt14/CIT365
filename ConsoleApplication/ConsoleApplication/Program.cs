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
            string myName;
            Console.Write("Please write your name: ");
            myName = Console.ReadLine();

            string location;
            Console.Write("Please write your location: ");
            location = Console.ReadLine();

            Console.WriteLine("Your name is " + myName + " and your location is " + location);

            var currentDate = DateTime.Now;

            Console.WriteLine("The current date is " + currentDate.ToString("d"));

            var christmasDay = new DateTime(2020, 12, 25);

            TimeSpan interval = christmasDay.Subtract(currentDate);

            Console.WriteLine("The amount of time till Christmas is: " + interval.Days);

            double width, height, woodLength, glassArea;
            string widthString, heightString;

            Console.Write("Please enter your width: ");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);

            Console.Write("Please enter your height: ");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);

            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);

            Console.WriteLine("The length of the wood is " +
            woodLength + " feet");
            Console.WriteLine("The area of the glass is " +
            glassArea + " square metres");

            Console.WriteLine("Please press any key to close the application");
            
            Console.ReadKey();

        }
    }
}
