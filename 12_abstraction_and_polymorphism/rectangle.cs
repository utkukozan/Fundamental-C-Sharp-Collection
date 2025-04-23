namespace _12_abstraction_and_polymorphism
{
    class Rectangle : Shape // Inherits from Shape
    {
        private double length;
        private double width;

        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

        // This method must be implemented by any derived class with override keyword
        public override double CalculateArea()
        {
            return length * width; // Calculate area of rectangle
        }

        // Rectangle class inherits from Shape class and provides its own implementation of the Draw method.
    }
}
