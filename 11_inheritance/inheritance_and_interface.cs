namespace _11_inheritance
{
    // Inheritance allows a class to inherit members (fields, properties, methods) from another class.
    // The class that is inherited from is called the base class (or parent class), and the class that inherits is called the derived class (or child class).
    // Usage of inheritance promotes code reusability and establishes a hierarchical relationship between classes.

    // Interfaces are contracts that define a set of methods and properties that a class must implement.
    // They allow for multiple inheritance in C#, as a class can implement multiple interfaces.
    // Interfaces are useful for defining common behavior across different classes without enforcing a specific implementation.

    // The difference between an interface and an abstract class is that an interface can only contain method signatures (without implementation), and properties, while an abstract class can contain both abstract methods (without implementation) and concrete methods (with implementation).

    // In this example, we define a base class called Animal (animal.cs) and derived classes called Dog and Cat (dog.cs, cat.cs).
    // Also, we define an interface called IAnimal (ianimal.cs).
    // The Dog class inherits from the Animal class, which means it has access to the members of the Animal class. (Dog is a type of Animal)
    // We also demonstrate method overriding and the use of the base keyword.
    // The interface IAnimal defines a contract for the Animal class, which means that any class that implements the IAnimal interface must provide an implementation for the methods defined in the interface.

    class InheritanceAndInterface
    {
        static void Main()
        {
            // Create an object of the Dog class
            Dog dog = new Dog("Buddy", 3);
            dog.Speak(); // Output: Woof!
            dog.DisplayInfo(); // Output: Name: Buddy, Age: 3
            dog.Bark(); // Output: Bark!

            // Create an object of the Cat class
            Cat cat = new Cat("Whiskers", 2);
            cat.Speak(); // Output: Meow!
            cat.DisplayInfo(); // Output: Name: Whiskers, Age: 2
            // cat.Bark(); // This line would cause a compile-time error because the Cat class does not have a Bark method

            // Create an object of the Animal class
            Animal animal = new Animal("Generic Animal", 5);
            animal.Speak(); // Output: Some generic animal sound
            animal.DisplayInfo(); // Output: Name: Generic Animal, Age: 5
        }
    }
}