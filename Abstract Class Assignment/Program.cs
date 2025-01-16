using System;

// Define an abstract class called Person
abstract class Person
{
    // Property to store the first name of the person
    public string FirstName { get; set; }

    // Property to store the last name of the person
    public string LastName { get; set; }

    // Abstract method SayName that must be implemented by derived classes
    public abstract void SayName();
}

// Employee class inherits from Person
class Employee : Person
{
    // Implement the SayName method to display the full name
    public override void SayName()
    {
        // Write the full name to the console in the specified format
        Console.WriteLine($"Name: {FirstName} {LastName}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Instantiate an Employee object with firstName "Sample" and lastName "Student"
        Employee employee = new Employee
        {
            FirstName = "Sample", // Set the FirstName property
            LastName = "Student"   // Set the LastName property
        };

        // Call the SayName method on the Employee object to display the name
        employee.SayName();
        Console.ReadLine();
    }
}