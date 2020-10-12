using System;

namespace RoomCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Room Calculator!");

            // Set up Loop
            bool done = false;
            while (!done)
            {
                // Collect Input
                // Length
                Console.Write("Please enter the length of the room: ");
                double length = double.Parse(Console.ReadLine());

                // Width
                Console.Write("Please enter the width of the room: ");
                double width = double.Parse(Console.ReadLine());

                // Height
                Console.Write("Please enter the height of the room: ");
                double height = double.Parse(Console.ReadLine());

                Console.WriteLine(" ");

                // Calculate dimensions

                double area = length * width;       // Area
                double perimeter = (2 * length) + (2 * width);  // Perimeter
                double volume = area * height;      // Volume

                Console.WriteLine($"Area: {area}");
                Console.WriteLine($"Perimeter: {perimeter}");
                Console.WriteLine($"Volume: {volume}");

                Console.WriteLine(" ");

                // Prompt user if they want to do another calculation (y means yes, n or anything else means no)
                Console.Write("Would you like to continue? (y/n) ");
                string selection = Console.ReadLine();
                if (!selection.Equals("y")) { done = true; }
            }
            Console.WriteLine("Thank you for using the Room Calculator!");
        }
    }
}
