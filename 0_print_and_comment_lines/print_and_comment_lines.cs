// The System namespace contains fundamental classes and base classes that define commonly-used value and reference data types, events and event handlers, interfaces, attributes, and processing exceptions
// But, C#10, .NET 6 and later versions do not require this directive, as it is included by default in the global using directives with csproj file
// <ImplicitUsings>enable</ImplicitUsings> in the csproj file enables implicit usings, which automatically includes commonly used namespaces

// This is comment line, comments are ignored by the compiler and are used to explain the code
/*
 This is a multi-line comment 
 that spans multiple lines
*/

// This System namespace contains fundamental classes and base classes that define commonly-used value and reference data types, events and event handlers, interfaces, attributes, and processing exceptions

namespace _0_print_and_comment_lines // Namespace declaration, defining a scope for the classes
// Namespaces must start with a letter or underscore
{
    class PrintAndCommentLines // This is a class declaration, defining a class named Program
    {
        static void Main()
        {
            // This is a single-line comment
            Console.WriteLine("Hello, World!"); // This prints "Hello, World!" to the console
            Console.Write("Testing"); // This prints "Testing" to the console without a newline
        }
    }
}