using System;

class Program
{
    static void Main()
    {
        // Print the current date and time to the console
        DateTime currentDateTime = DateTime.Now; // Get the current date and time
        Console.WriteLine("Current date and time: " + currentDateTime); // Display the current date and time

        // Ask the user for a number (in hours)
        Console.Write("Please enter a number of hours: "); // Prompt the user for input
        string userInput = Console.ReadLine(); // Read the user input from the console

        // Convert the user input to an integer
        int hours;
        // Check if the input is a valid integer
        if (int.TryParse(userInput, out hours)) // Try to convert the input to an integer
        {
            // Calculate the exact time it will be in X hours
            DateTime futureDateTime = currentDateTime.AddHours(hours); // Add the specified number of hours to the current time

            // Print the future date and time to the console
            Console.WriteLine($"In {hours} hours, it will be: {futureDateTime}"); // Display the calculated future time
        }
        else
        {
            // Inform the user about invalid input
            Console.WriteLine("Invalid input. Please enter a valid number."); // Inform the user that the input was not a valid integer
            Console.ReadLine();

        }
    }
}