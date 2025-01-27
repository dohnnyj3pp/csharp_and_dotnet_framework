using System;
using System.IO;

class Program
{
    static void Main()
    {
        // Ask the user for a number
        Console.Write("Please enter a number: ");
        string userInput = Console.ReadLine();

        // Log the number to a text file
        string filePath = "userNumber.txt";
        File.WriteAllText(filePath, userInput);

        // Read the text file back and print its contents
        string loggedNumber = File.ReadAllText(filePath);
        Console.WriteLine($"The number you entered is: {loggedNumber}");
        Console.ReadLine();
    }
}