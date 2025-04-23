namespace _10_classes_and_objects;

// In this example, we define a class called Person in another file => Person.cs.
// Same namespace as the main file.
class ClassesAndObjects
{
    static void Main()
    {
        // Objects are instances of classes, which means they are created based on the blueprint defined by the class
        // Create a new object of the class
        Person person = new Person("John", 30);

        // Call the method of the class
        person.Introduce();

        // Access the property of the class
        Console.WriteLine($"Name: {person.Name}");

        // Modify the property of the class
        person.Name = "Jane";
        Console.WriteLine($"Updated Name: {person.Name}");

        // Another object of the class
        Person anotherPerson = new Person("Alice", 25);
        anotherPerson.Introduce();

        // Static members in class can be accessed without creating an instance of the class
        Person.instanceCount = 1; // Accessing static member
        Console.WriteLine($"Instance Count: {Person.instanceCount}");

        // Destructor will be called when the object is no longer in use
        // This is usually when the program ends or when the object goes out of scope
        // Note: In C#, destructors are not commonly used, as the garbage collector automatically cleans up objects
        // However, if you need to perform cleanup, you can implement IDisposable interface and use the Dispose method

        // Access Specifiers
        // Public: Accessible from anywhere
        // Private: Accessible only within the class
        // Protected: Accessible only within the class and its derived classes
        // Internal: Accessible only within the same assembly
        // Protected Internal: Accessible within the same assembly and derived classes
        // Static: Belongs to the class itself rather than to any specific object
        // Abstract: Cannot be instantiated, but can be inherited
        // Sealed: Cannot be inherited
        // Virtual: Can be overridden in derived classes
        // Override: Used to provide a new implementation of a method in a derived class

    }
}