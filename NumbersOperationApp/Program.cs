using System;

namespace NumberOperationsApp
{
    // Define a static class called MathOperations
    public static class MathOperations
    {
        // Void method that divides the input number by 2 and displays the result
        public static void DivideByTwo(int number)
        {
            int result = number / 2; // Divide the number by 2
            Console.WriteLine($"The number {number} divided by 2 is: {result}"); // Output the result
        }

        // Method with output parameters to calculate the division and return result
        public static void DivideByTwoWithOutput(int number, out int result)
        {
            result = number / 2; // Calculate the result
        }

        // Overloaded method that accepts a double and divides it by 2
        public static void DivideByTwo(double number)
        {
            double result = number / 2; // Divide the number by 2
            Console.WriteLine($"The number {number} divided by 2 is: {result}"); // Output the result
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user for a number
            Console.WriteLine("Please enter an integer number:");
            int userNumber = int.Parse(Console.ReadLine()); // Read and parse user input

            // Call the method to divide the number by 2
            MathOperations.DivideByTwo(userNumber); // Call the void method

            // Call the output parameter method
            MathOperations.DivideByTwoWithOutput(userNumber, out int outputResult); // Call the method with output parameter
            Console.WriteLine($"Using output parameter, the number {userNumber} divided by 2 is: {outputResult}"); // Display the output

            // Demonstrate the overloaded method
            Console.WriteLine("Please enter a number with a decimal:");
            double userDoubleNumber = double.Parse(Console.ReadLine()); // Read and parse user input
            MathOperations.DivideByTwo(userDoubleNumber); // Call the overloaded method
            Console.ReadLine();
        }
    }
}