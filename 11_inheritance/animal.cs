namespace _11_inheritance
{
    class Animal : IAnimal
    {
        protected string Name;
        protected int Age;

        // Constructor of the Animal class, which initializes the properties
        // Derived classes can call this constructor using the base keyword
        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }

        // Method to display information about the animal
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }

        // Virtual method to be overridden in derived classes. It provides a overrideable implementation.
        public virtual void Speak()
        {
            Console.WriteLine("Some generic animal sound");
        }

        // Destructor of the Animal class
        ~Animal()
        {
            // Cleanup code if needed
            Console.WriteLine($"Animal {Name} is being destroyed.");
        }
    }
}
