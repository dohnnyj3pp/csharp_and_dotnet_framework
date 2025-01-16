// Define the Employee class
using System;

public class Employee
{
    // Properties for Employee class
    public int Id { get; set; }        // Property to hold the Employee ID
    public string FirstName { get; set; } // Property to hold the Employee's first name
    public string LastName { get; set; }  // Property to hold the Employee's last name

    // Overload the "==" operator to compare two Employee objects
    public static bool operator ==(Employee emp1, Employee emp2)
    {
        // Check if both objects are the same instance
        if (ReferenceEquals(emp1, emp2))
            return true; // If they are the same, return true

        // Check if either object is null
        if (emp1 is null || emp2 is null)
            return false; // If one is null, return false

        // Compare the Id properties of both Employee objects
        return emp1.Id == emp2.Id; // Return true if Ids are equal
    }

    // Overload the "!=" operator to complement the "==" operator
    public static bool operator !=(Employee emp1, Employee emp2)
    {
        // Use the overloaded "==" operator to determine inequality
        return !(emp1 == emp2); // Return true if they are not equal
    }

    // Override the Equals method for proper comparison
    public override bool Equals(object obj)
    {
        // Check if the object is an Employee
        if (obj is Employee other)
        {
            return this.Id == other.Id; // Compare Ids
        }
        return false; // Return false if not an Employee
    }

    // Override GetHashCode method to ensure consistent hashing
    public override int GetHashCode()
    {
        return Id.GetHashCode(); // Return the hash code based on Id
    }
}

// Main program to test the Employee class
public class Program
{
    public static void Main(string[] args)
    {
        // Instantiate two Employee objects
        Employee emp1 = new Employee { Id = 1, FirstName = "John", LastName = "Doe" }; // First Employee
        Employee emp2 = new Employee { Id = 1, FirstName = "Jane", LastName = "Smith" }; // Second Employee with same Id

        // Compare the two Employee objects using the overloaded "==" operator
        bool areEqual = emp1 == emp2; // Check if emp1 and emp2 are equal based on Id

        // Display the result of the comparison
        Console.WriteLine($"Are emp1 and emp2 equal? {areEqual}"); // Output: true
        Console.ReadLine();
    }
}