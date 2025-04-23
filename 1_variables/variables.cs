namespace _1_variables
{
    class Variables
    {
        static void Main()
        {
            // To declare a variable, you need to specify the type and the name of the variable
            // The type of the variable determines what kind of data it can hold
            // For example, an int variable can hold integer values, while a string variable can hold text

            //int: Store whole numbers between -2,147,483,648 and 2,147,483,647
            int age = 25;
            Console.WriteLine(age); // 25

            //string: Store text
            string name = "John Doe";
            Console.WriteLine(name); // John Doe

            //double: Store double-precision decimal numbers
            double weight = 70.5; //double is the default type for decimal numbers
            Console.WriteLine(weight); // 70.5

            //float: Store decimal numbers, but with less precision than double.
            float height = 5.9f; //f is used to indicate that this is a float
            Console.WriteLine(height); // 5.9

            //char: Store a single character
            char initial = 'J'; //single quotes are used for characters
            Console.WriteLine(initial); // J

            //byte: Store a single byte (0 to 255)
            byte byteValue = 255; //byte can hold values from 0 to 255
            Console.WriteLine(byteValue); // 255

            //bool: Store true or false values
            bool isStudent = true; //bool can hold only two values: true or false
            Console.WriteLine(isStudent); // True

            //long: Store large whole numbers
            long largeNumber = 9223372036854775807; //long can hold larger values than int
            Console.WriteLine(largeNumber); // 9223372036854775807

            //short: Store small whole numbers
            short smallNumber = 32767; //short can hold smaller values than int
            Console.WriteLine(smallNumber); // 32767

            //decimal: Store decimal numbers with high precision, typically used for financial calculations
            decimal price = 19.99m; //m is used to indicate that this is a decimal
            Console.WriteLine(price); // 19.99

            //var: Implicitly typed variable, the type is determined by the compiler based on the assigned value
            var city = "New York"; //var is used for implicitly typed variables, the type is determined by the value assigned
            var temperature = 98.6; //var can also be used for double values
            Console.WriteLine(city); // New York
            Console.WriteLine(temperature); // 98.6
            //city = 10; This will cause a compile-time error because city is already defined as a string
            city = "Los Angeles"; // You can change the value of a var variable, but not its type
            Console.WriteLine(city); // Los Angeles

            //object: The base type for all types in C#, can hold any data type
            // Different from var, object can hold any type of data, but requires casting to use it as a specific type
            object obj = "Hello, World!"; //object can hold any type of data, but requires casting to use it as a specific type
            Console.WriteLine(obj);
            obj = 42; //object can also hold an integer value
            Console.WriteLine(obj); // 42
            // int a = obj;  This will cause a runtime error because obj is an int, not a string
            // To use obj as a int, you need to cast it
            int a = (int)obj; // This will work, but you need to be sure that obj is actually an int
            Console.WriteLine(a); // 42

            //dynamic: A type that can hold any data type, the type is determined at runtime
            //Unlike object, dynamic does not require casting to use it as a specific type
            //Unlike var, dynamic can change its type at runtime
            dynamic anything = "Hello"; //dynamic can hold any type of data, the type is determined at runtime
            Console.WriteLine(anything); // Hello
            anything = 40; //anything can also hold an integer value
            Console.WriteLine(anything); // 42  

            //const: A constant variable, its value cannot be changed after it is assigned, declared at compile time
            const int constantValue = 100; //const is used to declare a constant variable
            Console.WriteLine(constantValue); // 100
            //constantValue = 200; This will cause a compile-time error because const variables cannot be changed

            //Structs: A struct is a value type that can hold multiple values
            //Structs are used to create complex data types that can hold multiple values
            //The definition of structs is similar to classes, but structs are value types and classes are reference types
            //Below is an example of a struct that holds multiple values, definition in the same file, but outside the class
            Person person;
            person.Name = "Alice"; //Assigning value to the Name field of the person struct
            person.Age = 30; //Assigning value to the Age field of the person struct
            Console.WriteLine(person.Name + " and age is " + person.Age);

            //Using variables in expressions
            //You can use variables in expressions to perform calculations or manipulate data
            int a1 = 5;
            int b1 = 10;
            int sum = a1 + b1; //sum is the result of adding a1 and b1
            Console.WriteLine(sum); // 15
            //You can also use variables in string interpolation to create formatted strings
            string message = $"The sum of {a1} and {b1} is {sum}"; //string interpolation is used to create formatted strings
            //Or
            string message2 = "The sum of " + a1 + " and " + b1 + " is " + sum; //string concatenation is used to create formatted strings
            Console.WriteLine(message); // The sum of 5 and 10 is 15
            Console.WriteLine(message2); // The sum of 5 and 10 is 15
            //You can also use variables in conditional statements to control the flow of your program

            //The identifiers (variable names) must follow these rules:
            //1. Must start with a letter or underscore (_)
            //2. Can contain letters, digits, and underscores
            //3. Cannot contain spaces or special characters (except for underscore)
            //4. Cannot be a reserved keyword (like int, string, etc.)
            //5. Case-sensitive (age and Age are different variables)
            //6. Cannot start with a digit
        }
    }
}

struct Person // Struct is a value type that can hold multiple values
{
    public string Name; // Name is a field of type string
    public int Age; // Age is a field of type int
}


