namespace _12_abstraction_and_polymorphism
{
    abstract class Shape
    {
        // Abstract method, this method has no implementation but must be implemented by derived classes
        // This method must be implemented by any derived class with override keyword
        public abstract double CalculateArea();

        // Concrete method, this method has implementation and can be used by derived classes
        public void Draw()
        {
            Console.WriteLine("Drawing the shape.");
        }
    }
}
