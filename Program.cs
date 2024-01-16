using System;

// Employee Class
public class Employee
{
    
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    // Overloading the "==" operator
    public static bool operator ==(Employee employee1, Employee employee2)
    {
        // Check if both objects are null or if their Id properties are equal
        return ReferenceEquals(employee1, null) && ReferenceEquals(employee2, null) ||
               !ReferenceEquals(employee1, null) && !ReferenceEquals(employee2, null) &&
               employee1.Id == employee2.Id;
    }

    // Overloading the "!=" operator for Employee class
    public static bool operator !=(Employee employee1, Employee employee2)
    {
        // Use the negation of the "==" operator
        return !(employee1 == employee2);
    }
}

// Program class for testing the Employee class
class Program
{
    static void Main()
    {
        // Instantiate two Employee objects and assign values to their properties
        Employee employee1 = new Employee { Id = 1, FirstName = "John", LastName = "Doe" };
        Employee employee2 = new Employee { Id = 2, FirstName = "Jane", LastName = "Smith" };

        // Compare the two Employee objects using overloaded operators
        bool areEqual = employee1 == employee2;
        bool areNotEqual = employee1 != employee2;

        // Display the results
        Console.WriteLine($"Are employees equal? {areEqual}");
        Console.WriteLine($"Are employees not equal? {areNotEqual}");
    }
}
