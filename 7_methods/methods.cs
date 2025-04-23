namespace _7_methods;

class Methods
{
    static void Main()
    {
        // Methods are used to perform actions, and they are defined with a name, return type, and parameters.
        // A method can return a value or be void (no return value).
        // You can define methods inside a class or struct.
        // For example, this main method is defined inside the Methods class. It is the entry point of the C# program.

        // In below example, we define a method called ExampleMethod that does not return (void) a value and does not take any parameters.
        // You can call this method from the Main method or any other method in the class.
        ExampleMethod(); // Call the ExampleMethod to execute its code.

        // You can also define methods that take parameters.
        // In below example, we define a method called ExampleMethodWithParameters that takes two integer parameters and print their sum.
        ExampleMethodWithParameters(2, 3);

        // You can also define methods that return a value. For example, you can define a method that takes two integers and returns their sum.
        int result = ExampleMethodReturnsInteger(2, 3); // Call the Add method and store the result in a variable.
        Console.WriteLine("Result of ExampleMethodReturnsInteger: " + result); // Output: 5

        // Some methods can use default parameters. For example, you can define a method that takes two integers and returns their sum, but if the second integer is not provided, it defaults to 0.
        int resultWithDefault = ExampleMethodWithDefaultParameter(2); // Call the method with one parameter, the second defaults to 0.
        Console.WriteLine("Result of ExampleMethodWithDefaultParameter: " + resultWithDefault); // Output: 2

        // You can also define methods that take an array as a parameter. For example, you can define a method that takes an array of integers and returns their sum.
        int[] numbers = { 1, 2, 3, 4, 5 }; // Declare and initialize an array of integers.
        int sum = SumArray(numbers); // Call the method to calculate the sum of the array elements.
        Console.WriteLine("Sum of array elements: " + sum); // Output: 15

        // Named arguments allow you to specify the names of the parameters when calling a method, making it easier to understand what each argument represents.
        // For example, if you have a method that takes multiple parameters, you can call it like this:
        ExampleMethodWithParameters(a: 5, b: 10); // Call the method with named arguments.
        ExampleMethodWithParameters(b: 10, a: 5); // Call the method with named arguments in a different order.

        // Method overloading allows you to define multiple methods with the same name but different parameter types or numbers.
        // In below example, we define two overloaded methods called OverloadedMethod.
        // One takes an integer as a parameter and returns its square, and the other takes a double as a parameter and returns its square.
        int squareInt = OverloadedMethod(5); // Call the method with an integer parameter.
        double squareDouble = OverloadedMethod(5.5); // Call the method with a double parameter.

        Console.WriteLine("Square of 5: " + squareInt); // Output: 25
        Console.WriteLine("Square of 5.5: " + squareDouble); // Output: 30.25

        // A method can call itself recursively. For example, you can define a method that calculates the factorial of a number using recursion.
        int factorialResult = Factorial(5); // Call the method to calculate the factorial of 5.
        Console.WriteLine("Factorial of 5: " + factorialResult); // Output: 120

    }

    static void ExampleMethod()
    {
        // This is a method definition. It does not return a value and does not take any parameters.
        // You can call this method from the Main method or any other method in the class.
        Console.WriteLine("Hello from ExampleMethod!");
    }

    static void ExampleMethodWithParameters(int a, int b)
    {
        Console.WriteLine("Sum of " + a + " and " + b + " is " + (a + b));
    }

    static int ExampleMethodReturnsInteger(int a, int b)
    {
        // This method takes two integers as parameters and returns their sum.
        return a + b; // Return the sum of a and b
    }

    static int ExampleMethodWithDefaultParameter(int a, int b = 0)
    {
        // This method takes two integers as parameters and returns their sum.
        // The second parameter has a default value of 0.
        return a + b; // Return the sum of a and b
    }

    static int SumArray(int[] numbers)
    {
        // This method takes an array of integers as a parameter and returns the sum of its elements.
        int sum = 0; // Initialize the sum to 0
        foreach (int number in numbers) // Iterate through each element in the array
        {
            sum += number; // Add the current element to the sum
        }
        return sum; // Return the total sum
    }

    static int OverloadedMethod(int a)
    {
        // This method takes one integer as a parameter and returns its square.
        return a * a; // Return the square of a
    }

    static double OverloadedMethod(double a)
    {
        // This method takes one double as a parameter and returns its square.
        return a * a; // Return the square of a
    }

    static int Factorial(int n)
    {
        // This method calculates the factorial of a number using recursion.
        if (n == 0 || n == 1) // Base case: factorial of 0 or 1 is 1
        {
            return 1; // Return 1
        }
        else
        {
            return n * Factorial(n - 1); // Recursive case: n * factorial of (n-1)
        }
    }
}