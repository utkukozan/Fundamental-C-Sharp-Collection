namespace _11_inheritance
{
    // Dog class inherits from Animal class
    // The Dog class has access to the members of the Animal class
    // This means that the Dog class can use the properties and methods defined in the Animal class
    // The Dog class is a derived class, and the Animal class is the base class
    // This class has a constructor, a destructor, and a method that overrides the Speak method from the Animal class
    // Also, it has a specific method called Bark that is not in the Animal class

    class Dog : Animal // Inherits from Animal class, (SealedAnimal class can not be inherited because of sealed)
    // Note: C# does not support multiple inheritance of classes, but it does support multiple inheritance of interfaces.
    // In this case, the Dog class inherits from the Animal class. If there is an additional interface, it can also be implemented. However, it cannot inherit from another class.
    {
        // Constructor of the Dog class, which calls the base class constructor
        public Dog(string name, int age) : base(name, age)
        {
            // Additional initialization for Dog can be done here
        }

        // Overriding the Speak method from the Animal class
        public override void Speak()
        {
            Console.WriteLine("Woof!");
        }

        // Specific method for the Dog class, which is not in the Animal class
        public void Bark()
        {
            Console.WriteLine("Bark!");
        }

        // Destructor of the Dog class
        ~Dog()
        {
            // Cleanup code if needed
            Console.WriteLine($"Dog {Name} is being destroyed.");
        }

        // The DisplayInfo method is inherited from the Animal class
    }
}
