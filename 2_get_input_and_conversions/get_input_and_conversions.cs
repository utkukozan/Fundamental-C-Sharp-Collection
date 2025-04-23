namespace _2_get_input_and_conversions
{
    class GetInputAndConversions
    {
        static void Main()
        {
            // To get input from the user, you can use the Console.ReadLine() method
            // This method reads a line of text from the console and returns it as a string
            Console.Write("Enter your name: "); // Prompt the user for input
            var name = Console.ReadLine(); // Read the input and store it in a variable
            Console.WriteLine("Hello, " + name + "!"); // Print a greeting message with the user's name

            //Also, you can use Console.Read() to read a int, double, float, etc. from the console
            Console.Write("Enter your age: "); // Prompt the user for input
            int age = Convert.ToInt32(Console.ReadLine()); // Read the input as string and convert it to int
            //If user enters a non-integer value, it will throw an exception, you can use TryParse to handle this, with if-else statements
            Console.WriteLine("Your age is: " + age); // Print the user's age

            // Also, converting string to int, double, float, etc. can be done using Convert class
            Console.Write("Enter your weight: "); // Prompt the user for input
            double weight = Convert.ToDouble(Console.ReadLine()); // Read the input as string and convert it to double
            Console.WriteLine("Your weight is: " + weight); // Print the user's weight

            //Other conversions can be done using the Convert class
            // Convert.ToInt32() for int
            // Convert.ToDouble() for double
            // Convert.ToSingle() for float
            // Convert.ToChar() for char
            // Convert.ToBoolean() for bool
            // Convert.ToByte() for byte
            // Convert.ToInt64() for long
            // Convert.ToInt16() for short
            // Convert.ToDecimal() for decimal
            // Convert.ToString() for string
            // Convert.ToDateTime() for DateTime

            //Also, explicit conversions can be done using casting
            // For example, to convert a double to an int, you can use (int) before the variable
            double pi = 3.14;
            int piInt = (int)pi; // This will truncate the decimal part and convert it to int
            Console.WriteLine("Pi as int: " + piInt); // Print the value of pi as int
            // This will print 3, because the decimal part is truncated
            // Note that this is a loss of precision, so be careful when using explicit conversions

            // Another conversion method is using the Parse method
            // For example, to convert a string to an int, you can use int.Parse(string)
            // This method will throw an exception if the string cannot be converted to the specified type
            // For example, if the string is not a valid number, it will throw a FormatException
            // To avoid this, you can use TryParse method, which returns a boolean indicating success or failure
            string numberString = "123";
            int number = int.Parse(numberString); // This will convert the string to int
            Console.WriteLine("Parsed number: " + number); // Print the parsed number
        }
    }
}

