using System;

namespace PackageExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display welcome message
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // Prompt the user for the package weight
            Console.Write("Please enter the package weight: ");
            float weight = float.Parse(Console.ReadLine());

            // Check if the package weight is too heavy
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                return; // End the program
            }

            // Prompt the user for package dimensions
            Console.Write("Please enter the package width: ");
            float width = float.Parse(Console.ReadLine());

            Console.Write("Please enter the package height: ");
            float height = float.Parse(Console.ReadLine());

            Console.Write("Please enter the package length: ");
            float length = float.Parse(Console.ReadLine());

            // Check if total dimensions exceed 50
            float dimensionTotal = width + height + length;
            if (dimensionTotal > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                return; // End the program
            }

            // Calculate the quote:
            // (width * height * length * weight) / 100
            float quote = (width * height * length * weight) / 100;

            // Display the final shipping quote formatted as currency
            Console.WriteLine($"Your estimated total for shipping this package is: ${quote:F2}");
            Console.WriteLine("Thank you!");
        }
    }
}
