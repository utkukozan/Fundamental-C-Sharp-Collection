namespace _12_abstraction_and_polymorphism
{
    class Circle : Shape // Inherits from Shape
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        // This method must be implemented by any derived class with override keyword
        public override double CalculateArea()
        {
            return Math.PI * radius * radius; // Calculate area of circle
        }

        // Circle class inherits from Shape class and provides its own implementation of the Draw method.
    }
}
