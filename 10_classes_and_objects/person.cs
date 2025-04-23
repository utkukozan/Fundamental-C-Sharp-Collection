namespace _10_classes_and_objects;

// Everything in C# is an object, including classes
// This is a simple class definition in C#
// A class is a blueprint for creating objects
// It can contain fields, properties, methods, and events
// Fields are variables that hold data
// Properties are special methods that provide a flexible mechanism to read, write, or compute the value of private fields
// Methods are functions that define the behavior of the class
// Events are notifications that something has happened in the class
// A class can also have a constructor, which is a special method that is called when an object of the class is created
// A class can also have a destructor, which is a special method that is called when an object of the class is destroyed
// A class can also implement interfaces, which are contracts that define a set of methods and properties that a class must implement
// A class can also inherit from another class, which means it can use the fields, properties, methods, and events of the base class

class Person
{
    // Fields
    private string name;
    private int age;

    // Constructor
    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    // Destructor
    ~Person()
    {
        // Cleanup code here
        Console.WriteLine($"Destructor called for {name}");
    }

    // Properties, which are special methods that provide a flexible mechanism to read, write, or compute the value of private fields
    // Properties are like fields, but they have get and set accessors
    public string Name
    {
        get { return name; } // Getter
        set { name = value; } // Setter
    }

    // Method
    public void Introduce()
    {
        Console.WriteLine($"Hello, my name is {name} and I am {age} years old.");
    }

    // Static members
    // Static members belong to the class itself rather than to any specific object
    // Static members can be accessed without creating an instance of the class
    // Static fields are shared among all instances of the class
    public static int instanceCount = 0;
}

