namespace _11_inheritance
{
    // Derived class Cat inherits from the base class Animal
    // The Cat class has access to the members of the Animal class
    // This means that the Cat class can use the properties and methods defined in the Animal class
    class Cat : Animal
    {
        // Note: C# does not support multiple inheritance of classes, but it does support multiple inheritance of interfaces.
        // In this case, the Cat class inherits from the Animal class. If there is an additional interface, it can also be implemented. However, it cannot inherit from another class.

        // Constructor of the Cat class, which calls the base class constructor
        public Cat(string name, int age) : base(name, age)
        {
            // Additional initialization for Cat can be done here
        }

        // Overriding the Speak method from the Animal class
        public override void Speak()
        {
            Console.WriteLine("Meow!");
        }

        // Destructor of the Cat class
        ~Cat()
        {
            // Cleanup code if needed
            Console.WriteLine($"Cat {Name} is being destroyed.");
        }

        // The DisplayInfo method is inherited from the Animal class
    }
}
