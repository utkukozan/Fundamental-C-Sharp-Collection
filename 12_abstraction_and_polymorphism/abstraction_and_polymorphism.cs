namespace _12_abstraction_and_polymorphism;

class AbstractionAndPolymorphism
{
    // Abstract classes are classes that cannot be instantiated directly. They are used to define a base class with common properties and methods that can be shared by derived classes.
    // Abstract classes can contain abstract methods (without implementation) and concrete methods (with implementation). But regular classes cannot contain abstract methods.

    // In this example, we define an abstract class called Shape (shape.cs) with an abstract method called Draw.
    // The Circle (circle.cs) and Rectangle (rectangle.cs) classes inherit from the Shape class and provide their own implementations of the Draw method.
    // This circle class cannot be instantiated directly, but it can be used as a base class for other classes.
    // Also, shape class has a concrete method called Draw that can be used by derived classes.
    // The Draw method is a concrete method that can be used by derived classes to draw the shape.
    // Also, has abstract method called CalculateArea that must be implemented by derived classes.

    static void Main()
    {
        // Create a Circle object
        Circle circle = new Circle(5);
        circle.Draw(); // Call the Draw method
        Console.WriteLine("Area of Circle: " + circle.CalculateArea()); // Call the CalculateArea method

        // Create a Rectangle object
        Rectangle rectangle = new Rectangle(4, 5);
        rectangle.Draw(); // Call the Draw method
        Console.WriteLine("Area of Rectangle: " + rectangle.CalculateArea()); // Call the CalculateArea method

        // Shape shape = new Shape(); // This line will cause an error because Shape is an abstract class and cannot be instantiated directly.


        // Here, we create a Circle object and a Rectangle object, both of which are derived from the Shape class.
        // In polymorphism, we can use the base class reference (Shape) to refer to derived class objects (Circle and Rectangle).
        // This allows us to call the same method (Draw) on different objects, and each object will provide its own implementation of the method.

        // This is an example of polymorphism, where we can use the same method name (Draw) for different objects (Circle and Rectangle).
        Shape circle2 = new Circle(3); // Create a Circle object using Shape reference
        Shape rectangle2 = new Rectangle(5, 6); // Create a Rectangle object using Shape reference
        Console.WriteLine("Area of Circle: " + circle2.CalculateArea()); // Call the Draw method on Circle object
        Console.WriteLine("Area of Rectangle: " + rectangle2.CalculateArea()); // Call the Draw method on Rectangle object

        // Now, we can use the same method (Draw) for different objects (Circle and Rectangle) 
        // by using the base class reference (Shape) to refer to derived class objects.
        // This demonstrates polymorphism: the same method name (Draw) can behave differently depending on the object (Circle or Rectangle).
        // The difference between the two approaches is that in the first example, we create Circle and Rectangle objects using their own class references,
        // while in the second example, we create Circle and Rectangle objects using the base class reference (Shape), 
        // making the code more flexible and easier to extend in the future.
        // Polymorphism allows us to use the same method (Draw) for different objects (Circle and Rectangle) 
        // through the base class reference (Shape). This makes the code more flexible and easier to extend, 
        // as we can add new shapes without changing the existing code. It promotes loose coupling between 
        // classes, reducing dependencies and making the code more maintainable in the long term.
        // You can also use polymorphism with interfaces, which are similar to abstract classes but can be implemented by multiple classes and can contain only method signatures without any implementation.
    }
}