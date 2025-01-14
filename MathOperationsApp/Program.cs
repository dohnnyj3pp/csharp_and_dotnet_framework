using System;

namespace MathOperationsApp
{
    // Define a class called MathOperations
    class MathOperations
    {
        // Method that takes two integers as parameters, with the second one being optional
        public int Add(int firstNumber, int secondNumber = 0)
        {
            // Perform addition and return the result
            return firstNumber + secondNumber;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the MathOperations class
            MathOperations mathOps = new MathOperations();

            // Prompt the user for the first number
            Console.WriteLine("Please enter the first number:");
            // Read and parse the input as an integer
            int firstNumber = int.Parse(Console.ReadLine());

            // Prompt the user for the second number, indicating it's optional
            Console.WriteLine("Please enter the second number (press Enter to skip):");
            string input = Console.ReadLine();
            int secondNumber;

            // Check if the user entered a second number
            if (string.IsNullOrEmpty(input))
            {
                // If not, call the Add method with only the first number
                int result = mathOps.Add(firstNumber);
                Console.WriteLine($"The result of adding {firstNumber} and the default (0) is: {result}");
            }
            else
            {
                // Parse the second number if provided
                secondNumber = int.Parse(input);
                // Call the Add method with both numbers
                int result = mathOps.Add(firstNumber, secondNumber);
                Console.WriteLine($"The result of adding {firstNumber} and {secondNumber} is: {result}");
            }

            // Optional: Test various combinations of numbers
            Console.WriteLine("\nTesting various combinations:");
            Console.WriteLine($"Add(5) = {mathOps.Add(5)}"); // Only first number
            Console.WriteLine($"Add(10, 5) = {mathOps.Add(10, 5)}"); // Both numbers
            Console.WriteLine($"Add(3, -2) = {mathOps.Add(3, -2)}"); // First positive, second negative
            Console.WriteLine($"Add(-5) = {mathOps.Add(-5)}"); // Negative first number
            Console.ReadLine();
        }
    }
}