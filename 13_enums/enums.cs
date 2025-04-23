namespace _13_enums;

// Enums are a special "class" that represents a group of constants (unchangeable/read-only variables).
// They are used to define a set of named values that can be used to represent a specific set of options or categories.
// Useful when you have a fixed set of related values that you want to represent in a more readable and maintainable way.

public enum Days // Enum declaration, with the name "Days", using enum keyword
{
    Sunday, // By default, the first value is 0, the second is 1, and so on.
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday
}

class Enums
{
    static void Main()
    {
        // Accessing an enum value
        Days today = Days.Wednesday;
        Console.WriteLine($"Today is: {today}");

        // Getting the integer value of an enum
        int dayValue = (int)today;
        Console.WriteLine($"The integer value of {today} is: {dayValue}");
    }
}