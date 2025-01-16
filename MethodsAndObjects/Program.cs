using System;

class Person
{
    // Property to store the first name of the person
    public string FirstName { get; set; }

    // Property to store the last name of the person
    public string LastName { get; set; }

    // Method to display the full name of the person
    public void SayName()
    {
        // Write the full name to the console in the specified format
        Console.WriteLine($"Name: {FirstName} {LastName}");
    }
}

class Employee : Person
{
    // Property to store the ID of the employee
    public int Id { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        // Instantiate and initialize an Employee object
        Employee employee = new Employee
        {
            FirstName = "Sample", // Set the FirstName property
            LastName = "Student",  // Set the LastName property
            Id = 1                 // Set the Id property for the employee
        };

        // Call the SayName method from the Person class to display the employee's name
        employee.SayName();
        Console.ReadLine();
    }
}