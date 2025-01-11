using System;

class Program
{
    static void Main()
    {
        // Welcome message for the user
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

        // Prompt the user for the package weight
        Console.WriteLine("Please enter the package weight:");
        double weight = Convert.ToDouble(Console.ReadLine());

        // Check if the weight exceeds 50
        if (weight > 50)
        {
            // Display error message and exit the program
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            return; // Exit the program

        }

        // Prompt the user for the package width
        Console.WriteLine("Please enter the package width:");
        double width = Convert.ToDouble(Console.ReadLine());

        // Prompt the user for the package height
        Console.WriteLine("Please enter the package height:");
        double height = Convert.ToDouble(Console.ReadLine());

        // Prompt the user for the package length
        Console.WriteLine("Please enter the package length:");
        double length = Convert.ToDouble(Console.ReadLine());

        // Check if the total dimensions exceed 50
        if (width + height + length > 50)
        {
            // Display error message and exit the program
            Console.WriteLine("Package too big to be shipped via Package Express.");
            return; // Exit the program
        }

        // Calculate the quote: (height * width * length * weight) / 100
        double quote = (height * width * length * weight) / 100;

        // Display the estimated shipping quote to the user
        Console.WriteLine($"Your estimated total for shipping this package is: ${quote:F2}"); // F2 formats the output to 2 decimal places
        Console.WriteLine("Thank you!"); // Thank the user for using the service
        Console.ReadLine();
    }
}
