namespace _18_generics;

// Generics are a way to create classes, methods, and interfaces that can work with any data type.
// They allow you to create reusable code that can work with different types without the need for type casting.
// Generics are part of the System.Collections.Generic namespace.
// MyGenericClass (my_generic_class.cs) is a generic class that can work with any data type.
// It has a generic type parameter T that can be replaced with any data type when creating an instance of the class.
// The class has a method called Display that takes a parameter of type T and displays it.

// Also, generic methods can be created within non-generic classes. GetValue is a generic method that takes a parameter of type T and returns it.

class Generics
{
    static void Main(string[] args)
    {
        MyGenericClass<int> intGeneric = new MyGenericClass<int>();
        intGeneric.Display(10); // Output: Value: 10
        // intGeneric.Display('Hello'); // Error: Cannot convert from 'string' to 'int'

        MyGenericClass<string> stringGeneric = new MyGenericClass<string>();
        stringGeneric.Display("Hello"); // Output: Value: Hello

        // Using the generic method
        int intValue = GetValue(10); // Output: 10
        string stringValue = GetValue("Hello"); // Output: Hello
        Console.WriteLine($"Int Value: {intValue}");

        // So, in generics, the T is a placeholder for the data type that will be used when the class or method is instantiated or called.
        // This T is optional, and you can use any name for the type parameter, but T is a common convention.
    }

    // Generic method
    public static T GetValue<T>(T value)
    {
        return value;
    }
}