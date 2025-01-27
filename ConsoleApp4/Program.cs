using System;

public class ExampleClass
{
    // Create a constant variable
    private const int MaxValue = 100; // This constant cannot be changed after it is assigned

    // Create a variable using the keyword "var"
    private var exampleVar = "Hello, World!"; // Using var to implicitly type the variable as a string

    // First constructor
    public ExampleClass()
    {
        Console.WriteLine("Default constructor called."); // Message indicating the default constructor was called
    }

    // Second constructor that takes a parameter
    public ExampleClass(string message) : this() // Chaining to the default constructor
    {
        Console.WriteLine("Parameterized constructor called with message: " + message); // Display the message passed to the constructor
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create an instance of ExampleClass using the parameterized constructor
        ExampleClass example = new ExampleClass("This is a test."); // This will call the parameterized constructor
    }
}