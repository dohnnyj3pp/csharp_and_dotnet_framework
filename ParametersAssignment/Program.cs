using System; // Import necessary namespace for Console

using System.Collections.Generic; // Import namespace for List<T>

public class Employee<T>
{
    // Properties for Employee class
    public int Id { get; set; } // Property to hold the Employee ID
    public string FirstName { get; set; } // Property to hold the Employee's first name
    public string LastName { get; set; } // Property to hold the Employee's last name

    // Property to hold a list of things of type T
    public List<T> Things { get; set; } // Generic list to store items of type T

    // Overload the "==" operator to compare two Employee objects
    public static bool operator ==(Employee<T> emp1, Employee<T> emp2)
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
    public static bool operator !=(Employee<T> emp1, Employee<T> emp2)
    {
        // Use the overloaded "==" operator to determine inequality
        return !(emp1 == emp2); // Return true if they are not equal
    }

    // Override the Equals method for proper comparison
    public override bool Equals(object obj)
    {
        // Check if the object is an Employee
        if (obj is Employee<T> other)
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

// Main program to test the generic Employee class
public class Program
{
    public static void Main(string[] args)
    {
        // Instantiate an Employee object with string as the generic parameter
        Employee<string> stringEmployee = new Employee<string>
        {
            Id = 1, // Assign ID
            FirstName = "John", // Assign first name
            LastName = "Doe", // Assign last name
            Things = new List<string> { "Pencil", "Notebook", "Eraser" } // Assign a list of strings to Things
        };

        // Instantiate an Employee object with int as the generic parameter
        Employee<int> intEmployee = new Employee<int>
        {
            Id = 2, // Assign ID
            FirstName = "Jane", // Assign first name
            LastName = "Smith", // Assign last name
            Things = new List<int> { 1, 2, 3 } // Assign a list of integers to Things
        };

        // Print all the things for the string employee
        Console.WriteLine("Things for stringEmployee:");
        foreach (var item in stringEmployee.Things) // Loop through each item in Things
        {
            Console.WriteLine(item); // Print the item to the console
        }

        // Print all the things for the integer employee
        Console.WriteLine("\nThings for intEmployee:");
        foreach (var item in intEmployee.Things) // Loop through each item in Things
        {
            Console.WriteLine(item); // Print the item to the console
            Console.ReadLine();
        }
    }
}