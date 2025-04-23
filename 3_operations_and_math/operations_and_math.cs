#pragma warning disable CS0219, IDE0059, IDE0075 //This pragma disables the warnings for unused variables and expressions, not needed in this context.

namespace _3_operations_and_math;

class OperationsAndMath
{
    static void Main()
    {
        //In C#, you can perform various mathematical operations using operators
        /* Some of the common operators are:
         + : Addition
         - : Subtraction
         * : Multiplication
         / : Division
        % : Modulus (remainder)
        ++ : Increment
        -- : Decrement
        = : Assignment
        += : Add and assign
        -= : Subtract and assign
        *= : Multiply and assign
        /= : Divide and assign
        %= : Modulus and assign
        == : Equal to
        != : Not equal to
        > : Greater than
        < : Less than
        >= : Greater than or equal to
        <= : Less than or equal to
        && : Logical AND
        || : Logical OR
        ! : Logical NOT
        ?: : Ternary operator (conditional operator)
        & : Bitwise AND
        | : Bitwise OR
        ^ : Bitwise XOR
        ~ : Bitwise NOT
        << : Left shift
        >> : Right shift
        */

        int n = 10;
        int m = 3;
        int sum = n + m; // 13
        int difference = n - m; // 7
        int product = n * m; // 30
        int quotient = n / m; // 3
        int remainder = n % m; // 1
        int increment = n++; // 10 (postfix increment, n becomes 11 after this line)
        int decrement = n--; // 11 (postfix decrement, n becomes 10 after this line)

        int a = 5;
        int b = 10;
        bool isEqual = (a == b); // false
        bool isNotEqual = (a != b); // true
        bool isGreater = (a > b); // false
        bool isLess = (a < b); // true
        bool isGreaterOrEqual = (a >= b); // false
        bool isLessOrEqual = (a <= b); // true
        bool logicalAnd = (a < b && a > 0); // true
        bool logicalOr = (a < b || a < 0); // true
        bool logicalNot = !(a < b); // a<b is true, but !(a<b) is false
        bool ternaryOperator = (a < b) ? true : false; // if a < b is true, then ternaryOperator is true, else false

        // Bitwise operations, useful for low-level programming, bit manipulation, and performance optimization
        int bitwiseAnd = a & b; // 0 (binary 0101 & 1010 = 0000)
        int bitwiseOr = a | b; // 15 (binary 0101 | 1010 = 1111)
        int bitwiseXor = a ^ b; // 15 (binary 0101 ^ 1010 = 1111)
        int bitwiseNot = ~a; // -6 (binary NOT of 0101 is 1010, which is -6 in two's complement)
        int leftShift = a << 1; // 10 (binary 0101 << 1 = 1010)
        int rightShift = a >> 1; // 2 (binary 0101 >> 1 = 0010)

        // In C#, you can also use the Math class for more complex mathematical operations
        double squareRoot = Math.Sqrt(16); // 4
        double power = Math.Pow(2, 3); // 8 (2 raised to the power of 3)
        double absoluteValue = Math.Abs(-5); // 5
        double max = Math.Max(5, 10); // 10 (maximum of 5 and 10)
        double min = Math.Min(5, 10); // 5 (minimum of 5 and 10)
        double randomValue = new Random().NextDouble(); // Random value between 0.0 and 1.0
        double randomInt = new Random().Next(1, 100); // Random integer between 1 and 100
        double pi = Math.PI; // 3.141592653589793
        double e = Math.E; // 2.718281828459045
        double log = Math.Log(10); // Natural logarithm of 10
        double log10 = Math.Log10(10); // Base 10 logarithm of 10
        double sin = Math.Sin(Math.PI / 2); // 1 (sine of 90 degrees)
        double cos = Math.Cos(Math.PI); // -1 (cosine of 180 degrees)
        double tan = Math.Tan(Math.PI / 4); // 1 (tangent of 45 degrees)
        double exp = Math.Exp(1); // e (Euler's number)
        double round = Math.Round(3.14); // 3 (rounds to the nearest integer)
        double floor = Math.Floor(3.14); // 3 (rounds down to the nearest integer)
        double ceiling = Math.Ceiling(3.14); // 4 (rounds up to the nearest integer)
        double log2 = Math.Log(8, 2); // 3 (logarithm of 8 base 2)
        double log10_2 = Math.Log10(100); // 2 (logarithm of 100 base 10)
    }
}