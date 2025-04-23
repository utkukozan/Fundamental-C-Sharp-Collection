namespace _4_conditional_statements;
class ConditionalStatements
{
    static void Main()
    {
        // In C#, you can use conditional statements to control the flow of your program based on certain conditions.
        // The most common conditional statements are if, else if, else, switch, and the conditional (ternary) operator.

        int number = 10;

        // if statement
        if (number > 0)
        {
            Console.WriteLine("The number is positive.");
        }

        // if-else statement
        if (number < 0)
        {
            Console.WriteLine("The number is negative.");
        }
        else
        {
            Console.WriteLine("The number is non-negative.");
        }

        // if-else if-else statement
        if (number > 0)
        {
            Console.WriteLine("The number is positive.");
        }
        else if (number < 0)
        {
            Console.WriteLine("The number is negative.");
        }
        else
        {
            Console.WriteLine("The number is zero.");
        }

        // Nested if statement
        if (number != 0)
        {
            if (number > 0) // Nested if, run only if the outer if is true
            {
                Console.WriteLine("The number is positive.");
            }
            else
            {
                Console.WriteLine("The number is negative.");
            }
        }
        else
        {
            Console.WriteLine("The number is zero.");
        }

        // switch statement
        switch (number)
        {
            case 1:
                Console.WriteLine("The number is one.");
                break; // Break statement is used to exit the switch block
            case 2:
                Console.WriteLine("The number is two.");
                break;
            default: // Default case is executed if none of the above cases match
                Console.WriteLine("The number is neither one nor two.");
                break;
        }

        // Conditional (ternary) operator
        string result = (number > 0) ? "Positive" : "Non-positive";
        Console.WriteLine($"The number is {result}.");

        // Another switch statement
        string day = "Monday";
        switch (day)
        {
            case "Monday":
                Console.WriteLine("It's Monday.");
                break;
            case "Tuesday":
                Console.WriteLine("It's Tuesday.");
                break;
            case "Wednesday":
                Console.WriteLine("It's Wednesday.");
                break;
            case "Thursday":
                Console.WriteLine("It's Thursday.");
                break;
            case "Friday":
                Console.WriteLine("It's Friday.");
                break;
            case "Saturday":
                Console.WriteLine("It's Saturday.");
                break;
            case "Sunday":
                Console.WriteLine("It's Sunday.");
                break;
            default:
                Console.WriteLine("Invalid day.");
                break;
        }
    }
}