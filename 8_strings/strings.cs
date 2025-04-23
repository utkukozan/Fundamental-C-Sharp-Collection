using System.Text; // StringBuilder is used for mutable strings, which can be modified without creating new instances.

namespace _8_strings;

class Strings
{
    static void Main(string[] args)
    {
        string str1 = "Hello"; // String declaration and initialization
        string str2 = "World"; // String declaration and initialization
        string str3 = str1 + " " + str2; // Concatenation
        Console.WriteLine(str3);

        // String interpolation
        Console.WriteLine($"{str1} {str2}"); // "Hello World"

        // String length
        Console.WriteLine($"Length of str3: {str3.Length}"); // 11

        // String comparison
        Console.WriteLine($"str1 == str2: {str1 == str2}"); // false
        Console.WriteLine($"str1.Equals(str2): {str1.Equals(str2)}"); // false

        // String methods
        Console.WriteLine($"Uppercase: {str3.ToUpper()}"); // "HELLO WORLD"
        Console.WriteLine($"Lowercase: {str3.ToLower()}"); // "hello world"
        Console.WriteLine($"Substring: {str3.Substring(0, 5)}"); // "Hello"
        Console.WriteLine($"Index of 'o': {str3.IndexOf('o')}"); // 4
        Console.WriteLine($"Last index of 'o': {str3.LastIndexOf('o')}"); // 7
        Console.WriteLine($"Replace 'o' with 'a': {str3.Replace('o', 'a')}"); // "Hella Warld"
        Console.WriteLine($"Split: {string.Join(", ", str3.Split(' '))}"); // "Hello, World"
        Console.WriteLine($"Trim: {str3.Trim()}"); // "Hello World", removes leading and trailing whitespace, if any
        Console.WriteLine($"Pad left: {str3.PadLeft(20)}"); // "       Hello World"
        Console.WriteLine($"Pad right: {str3.PadRight(20)}"); // "Hello World       "
        Console.WriteLine($"Insert: {str3.Insert(5, " Beautiful")}"); // "Hello Beautiful World"
        Console.WriteLine($"Remove: {str3.Remove(5)}"); // "Hello"
        Console.WriteLine($"Starts with 'Hello': {str3.StartsWith("Hello")}"); // true
        Console.WriteLine($"Ends with 'World': {str3.EndsWith("World")}"); // true
        Console.WriteLine($"Contains 'lo': {str3.Contains("lo")}"); // true
        Console.WriteLine($"String to char array: {string.Join(", ", str3.ToCharArray())}"); // "H, e, l, l, o,  , W, o, r, l, d"
        Console.WriteLine($"String to byte array: {string.Join(", ", System.Text.Encoding.UTF8.GetBytes(str3))}"); // "72, 101, 108, 108, 111, 32, 87, 111, 114, 108, 100"
        Console.WriteLine($"String to int: {int.Parse("123")}"); // 123
        Console.WriteLine($"String to double: {double.Parse("123.45")}"); // 123.45
        Console.WriteLine($"String to bool: {bool.Parse("true")}"); // true
        Console.WriteLine($"String to DateTime: {DateTime.Parse("2023-10-01")}"); // 1.10.2023 00:00:00
        Console.WriteLine($"String to TimeSpan: {TimeSpan.Parse("01:30:00")}"); // 01:30:00
        Console.WriteLine($"String to Guid: {Guid.NewGuid()}"); // Generates a new GUID, unique identifier
        Console.WriteLine($"String to Uri: {new Uri("https://www.example.com")}"); // "https://www.example.com/"

        // String formatting
        int number = 42;
        Console.WriteLine($"Formatted number: {number:D5}"); // "00042" (pad with zeros)
        Console.WriteLine($"Formatted number: {number:F2}"); // "42.00" (fixed-point format)
        Console.WriteLine($"Formatted number: {number:X}"); // "2A" (hexadecimal format)
        Console.WriteLine($"Formatted number: {number:P}"); // "4200.00 %" (percentage format)
        Console.WriteLine($"Formatted number: {number:C}"); // "$42.00" (currency format)
        Console.WriteLine($"Formatted number: {number:N}"); // "42.00" (number format)
        Console.WriteLine($"Formatted number: {number:E}"); // "4.200000E+001" (scientific notation)
        Console.WriteLine($"Formatted number: {number:G}"); // "42" (general format)
        Console.WriteLine($"Formatted number: {number:R}"); // "42" (round-trip format)
        Console.WriteLine($"Formatted number: {number:X2}"); // "2A" (hexadecimal format with padding)

        // StringBuilder
        // StringBuilder is used for mutable strings, which can be modified without creating new instances. System.Text library is used for StringBuilder.
        StringBuilder sb = new();
        sb.Append("Hello");
        sb.Append(" ");
        sb.Append("World");
        Console.WriteLine($"StringBuilder: {sb.ToString()}"); // "Hello World"
    }
}