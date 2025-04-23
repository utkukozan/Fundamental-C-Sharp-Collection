namespace _14_exception_handling;

// Exception: An error that occurs during the execution of a program.
// Exception Handling: The process of responding to the occurrence of exceptions.
// Try-Catch Block: A block of code that attempts to execute a piece of code and catches exceptions if they occur.
// Finally Block: A block of code that executes after the try-catch block, regardless of whether an exception occurred or not.
// Throwing Exceptions: The process of generating an exception manually using the throw statement.
// Custom Exception: A user-defined exception that inherits from the Exception class.

class ExceptionHandling
{
    static void Main(string[] args)
    {
        // Example of a try-catch block
        int number = 0; // Initialize number to 0 to avoid uninitialized variable error
        try
        {
            // Try block is where you write code that may cause an exception
            Console.WriteLine("Enter a number:");
            number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"You entered: {number}");
        }
        catch (FormatException ex)
        {
            // Catch block is where you handle the exception
            // This blocks can be used multiple times for different exceptions
            Console.WriteLine("Invalid input. Please enter a valid number.");
            Console.WriteLine(ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("An unexpected error occurred.");
            Console.WriteLine(ex.Message);
            throw; // Rethrow the exception to propagate it further
        }
        finally
        {
            // Finally block is executed regardless of whether an exception occurred or not
            // It is optional, but useful for cleanup code
            Console.WriteLine("Execution completed.");
        }

        // Example of throwing an custom exception
        try
        {
            checkAge(number); // This will throw an exception if number is less than 18
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        // Example of nested try-catch blocks
        try
        {
            try
            {
                Console.WriteLine("Enter a number to divide this number:");
                int divisor = Convert.ToInt32(Console.ReadLine());
                int result = number / divisor;
                Console.WriteLine($"Result: {result}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Cannot divide by zero.");
                Console.WriteLine(ex.Message);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("An unexpected error occurred in the nested block.");
            Console.WriteLine(ex.Message);
        }
    }

    static void checkAge(int age)
    {
        if (age < 18)
        {
            throw new ArithmeticException("Access denied - You must be at least 18 years old.");
        }
        else
        {
            Console.WriteLine("Access granted - You are old enough!");
        }
    }

}