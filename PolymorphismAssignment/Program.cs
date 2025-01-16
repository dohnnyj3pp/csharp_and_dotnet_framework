using System;

// Define an interface called IQuittable
public interface IQuittable
{
    // Define a void method Quit() to be implemented by classes that inherit this interface
    void Quit();
}

// Abstract class Person
abstract class Person
{
    // Property to store the first name of the person
    public string FirstName { get; set; }

    // Property to store the last name of the person
    public string LastName { get; set; }

    // Abstract method SayName that must be implemented by derived classes
    public abstract void SayName();
}

// Employee class inherits from Person and implements IQuittable
class Employee : Person, IQuittable
{
    // Implement the SayName method to display the full name
    public override void SayName()
    {
        // Write the full name to the console in the specified format
        Console.WriteLine($"Name: {FirstName} {LastName}");
    }

    // Implement the Quit method from the IQuittable interface
    public void Quit()
    {
        // Display a message indicating that the employee has quit
        Console.WriteLine($"{FirstName} {LastName} has quit the job.");
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

        // Use polymorphism to create an object of type IQuittable
        IQuittable quittableEmployee = employee;

        // Call the Quit method on the IQuittable object
        quittableEmployee.Quit();
        Console.ReadLine();
    }
}