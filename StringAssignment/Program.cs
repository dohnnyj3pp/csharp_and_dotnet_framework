using System; // Importing the System namespace for basic functionalities
using System.Text; // Importing the System.Text namespace for using StringBuilder

class Program
{
    static void Main(string[] args)
    {
        // Step 1: Concatenate three strings
        string str1 = "Hello, ";
        string str2 = "this is ";
        string str3 = "a string concatenation example.";

        // Concatenate the three strings into one
        string concatenatedString = str1 + str2 + str3;

        // Print the concatenated string to the console
        Console.WriteLine("Concatenated String: " + concatenatedString);

        // Step 2: Convert a string to uppercase
        string originalString = "this will be uppercase."; // Define the original string

        // Convert the original string to uppercase
        string upperCaseString = originalString.ToUpper();

        // Print the uppercase string to the console
        Console.WriteLine("Uppercase String: " + upperCaseString);

        // Step 3: Create a StringBuilder and build a paragraph of text
        StringBuilder paragraph = new StringBuilder(); // Initialize a new StringBuilder instance

        // Add sentences to the StringBuilder one at a time
        paragraph.Append("This is the first sentence. "); // Append the first sentence
        paragraph.Append("Here comes the second sentence. "); // Append the second sentence
        paragraph.Append("Finally, this is the third sentence."); // Append the third sentence

        // Print the built paragraph to the console
        Console.WriteLine("Built Paragraph: " + paragraph.ToString());

        // Wait for user input before closing the console window
        Console.ReadLine();
    }
}