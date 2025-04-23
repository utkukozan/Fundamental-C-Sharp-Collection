namespace _11_inheritance
{
    // Sealed classes cannot be inherited. They are used to prevent further inheritance of a class.
    // This is useful when you want to prevent a class from being a base class for other classes.
    // In this example, we define a sealed class called SealedAnimal.

    // The SealedAnimal class cannot be inherited by any other class.
    sealed class SealedAnimal
    {
        // Properties of the SealedAnimal class
        public string Name { get; set; }
        public int Age { get; set; }
        // Constructor of the SealedAnimal class
        public SealedAnimal(string name, int age)
        {
            Name = name;
            Age = age;
        }
        // Method to display information about the sealed animal
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }
}
