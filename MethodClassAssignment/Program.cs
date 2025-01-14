using System;

namespace MathDisplayApp
{
    // Define a class called MathDisplay
    class MathDisplay
    {
        // Method that takes two integers as parameters
        public void DisplayAndOperate(int firstNumber, int secondNumber)
        {
            // Perform a math operation on the first number (e.g., square it)
            int result = firstNumber * firstNumber; // Squaring the first number

            // Display the result of the operation
            Console.WriteLine($"The square of {firstNumber} is: {result}");

            // Display the second number
            Console.WriteLine($"The second number is: {secondNumber}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the MathDisplay class
            MathDisplay mathDisplay = new MathDisplay();

            // Call the DisplayAndOperate method with two numbers
            mathDisplay.DisplayAndOperate(4, 10); // Positional parameters

            // Call the DisplayAndOperate method using named parameters
            mathDisplay.DisplayAndOperate(secondNumber: 20, firstNumber: 5); // Named parameters
            Console.ReadLine();
        }
    }
}
