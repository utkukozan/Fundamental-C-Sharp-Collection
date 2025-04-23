namespace _9_structs;

class Structs
{
    // Structs are helps to define a value type that can contain data and methods. 
    // They are similar to classes but are value types, meaning they are stored on the stack rather than the heap.
    // Structs are useful for small data structures that do not require inheritance or polymorphism.
    // Structs are not used as frequently as classes in C# because they are less flexible.

    // Structs are defined using the struct keyword, followed by the name of the struct and its members.
    struct Point
    {
        // Fields : Variables that hold data. In this case, we have two integer fields: X and Y.
        // In this case, we have two integer fields: X and Y.
        public int X; // X coordinate variable
        public int Y; // Y coordinate variable

        // Constructor : A special method that is called when an instance of the struct is created. It initializes the struct's members.
        public Point(int x, int y) // Constructor to initialize the struct
        {
            X = x;
            Y = y;
        }

        // Method : A function that is defined within the struct. It can perform operations on the struct's members or return values.
        // Method to display the point
        public void Display()
        {
            Console.WriteLine($"Point: ({X}, {Y})");
        }
    }

    interface IShape // Interface to define a shape
    {
        void Display(); // Method to display the shape
    }

    // Structs can also implement interfaces, which allows them to define a contract for behavior.
    // For example: square struct inherits from shape struct in below.

    struct Square : IShape // Struct to represent a square, implementing the IShape interface
    {
        public Point TopLeft; // Top-left corner of the square. Point struct can be used here. 
        public int SideLength; // Length of the sides of the square
        // Constructor to initialize the square
        public Square(Point topLeft, int sideLength)
        {
            TopLeft = topLeft;
            SideLength = sideLength;
        }
        // Method to display the square, if this method is not implemented, it will throw an error. Because it is an interface method from IShape.
        // So, IShape interface is behavior contract for Square struct.
        public void Display()
        {
            Console.WriteLine($"Square: TopLeft({TopLeft.X}, {TopLeft.Y}), SideLength: {SideLength}");
        }
    }

    static void Main()
    {
        // Creating an instance of the struct
        Point p1 = new Point(10, 20); // Creating a new Point struct with X=10 and Y=20

        p1.Display(); // Calling the Display method to print the point
                      // Creating another instance of the struct

        Point p2 = new Point(30, 40); // Creating a new Point struct with X=30 and Y=40
        p2.Display(); // Calling the Display method to print the point

        // Changeing the values of the struct
        p1.X = 50; // Changing the X coordinate of p1 to 50
        p1.Y = 60; // Changing the Y coordinate of p1 to 60
        p1.Display(); // Calling the Display method to print the updated point

        // Structs can also be used in arrays
        Point[] points = new Point[2]; // Creating an array of Point structs
        points[0] = p1; // Assigning the first point to the array
        points[1] = p2; // Assigning the second point to the array
        foreach (Point p in points) // Looping through each point in the array
        {
            p.Display(); // Calling the Display method to print each point
        }

        // Creating an instance of the Square struct
        Square square = new Square(new Point(5, 5), 10); // Creating a new Square struct with TopLeft(5, 5) and SideLength=10
        square.Display(); // Calling the Display method to print the square
    }
}