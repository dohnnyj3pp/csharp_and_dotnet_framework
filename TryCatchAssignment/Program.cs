using System;

class Program
{
    static void Main(string[] args)
    {
        // Prompt the user to enter their age
        Console.WriteLine("Please enter your age:");

        try
        {
            // Read the user's input and convert it to an integer
            int age = Convert.ToInt32(Console.ReadLine());

            // Check if the entered age is zero or negative
            if (age <= 0)
            {
                // Throw an exception if the age is zero or negative
                throw new ArgumentOutOfRangeException("Age must be a positive number.");
            }

            // Calculate the year the user was born
            int currentYear = DateTime.Now.Year; // Get the current year
            int birthYear = currentYear - age; // Calculate the birth year

            // Display the calculated birth year
            Console.WriteLine($"You were born in the year: {birthYear}");
        }
        catch (ArgumentOutOfRangeException ex)
        {
            // Handle the specific case where age is zero or negative
            Console.WriteLine($"Error: {ex.Message}"); // Display the error message
        }
        catch (FormatException)
        {
            // Handle the case where the input was not a valid integer
            Console.WriteLine("Error: Please enter a valid number for your age."); // Display an error message for invalid format
        }
        catch (Exception ex)
        {
            // Handle any other exceptions that may occur
            Console.WriteLine($"An unexpected error occurred: {ex.Message}"); // Display a general error message
        }
    }
}