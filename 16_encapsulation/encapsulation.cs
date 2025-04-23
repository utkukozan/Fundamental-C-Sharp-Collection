namespace _16_encapsulation;

// Encapsulation means bundling the data (attributes) and methods (functions) that operate on the data into a single unit or class.
// It restricts direct access to some of the object's components and can prevent the accidental modification of data.
// Useful for hiding the internal state and requiring all interaction to be performed through an object's methods.

// Person class (person.cs) has encapsulated properties and methods.
class Encapsulation
{
    static void Main()
    {
        // Create a new instance of the Person class
        Person person = new Person("John", 30);

        // Access the public properties with getters and setters
        Console.WriteLine($"Name: {person.Name}");
        //Console.WriteLine($"Age: {person.Age}"); This will cause an error because Age has a private getter

        // Attempt to set the private property directly (will cause an error)
        person.Age = 31; // This is allowed because Age has a public setter

        // person.SocialSecurityNumber = "123-45-6789"; // Error: 'Person.SocialSecurityNumber' is inaccessible due to its protection level, private setter
        // Use the public method to set the private property
        person.SetSocialSecurityNumber("123-45-6789");

        // Display the person's information
        person.DisplayInfo(); // This will show the name, age, and social security number
    }
}