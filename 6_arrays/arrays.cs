#pragma warning disable IDE0300, IDE0059

namespace _6_arrays;

class Arrays
{
    static void Main()
    {
        // Arrays are used to store multiple values in a single variable, instead of declaring separate variables for each value.
        // In C#, arrays are zero-indexed, meaning the first element is at index 0.
        // Declare and initialize an array
        int[] numbers = new int[3]; // Array of size 3, initialized to 0 by default
        string[] names = new string[3]; // Array of size 3, initialized to null by default

        numbers[0] = 1; // Assigning values to the array
        numbers[1] = 2;
        numbers[2] = 3;

        // You can also declare and initialize an array in one line
        int[] moreNumbers = [4, 5, 6]; // Array of size 3, initialized with values 4, 5, and 6
        // An alternative syntax
        int[] anotherArray = { 7, 8, 9 }; // Array of size 3, initialized with values 7, 8, and 9

        // You can get the length of an array using the Length property
        Console.WriteLine($"Length of numbers array: {numbers.Length}"); // Output: 3

        // You can sort an array using the Array.Sort method
        Array.Sort(numbers); // Sorts the array in ascending order , so 1, 2, 3 will be sorted to 1, 2, 3
        // To sort in descending order, you can use Array.Reverse after sorting
        Array.Reverse(numbers); // Reverses the order of the elements in the array, so 1, 2, 3 will be sorted to 3, 2, 1

        // You can find the index of an element using Array.IndexOf
        int index = Array.IndexOf(numbers, 2); // Finds the index of the element 2 in the array
        Console.WriteLine($"Index of 2 in numbers array: {index}"); // Output: 1

        // You can check if an array contains a specific element using Array.Exists
        bool exists = Array.Exists(numbers, element => element == 2); // Checks if the element 2 exists in the array
        Console.WriteLine($"Does 2 exist in numbers array? {exists}"); // Output: True

        // You can copy an array using Array.Copy
        int[] copiedArray = new int[numbers.Length]; // Create a new array of the same length
        Array.Copy(numbers, copiedArray, numbers.Length); // Copies the elements from numbers to copiedArray

        // Accessing array elements
        Console.WriteLine($"First element: {numbers[0]}"); // Output: 1

        // Print the elements of the array
        Console.WriteLine("Array elements:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }

        // Example: Calculate the sum of the array elements
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"Sum of array elements: {sum}");

        // You can clear an array using Array.Clear
        Array.Clear(numbers, 0, numbers.Length); // Clears the elements in the numbers array, setting them to 0

        // Example: Find the maximum element in the array
        int[] nums = [1, 2, 3, 4, 5];
        int max = nums[0]; // Initialize max to the first element, so 1 is the max now.
        foreach (int number in numbers)
        {
            if (number > max) // Compare each element with the current max
            {
                max = number; // Update max if the current element is greater
            }
        }

        // Multidimensional arrays
        int[,] multiArray = new int[2, 3]; // 2D array with 2 rows and 3 columns, initialized to 0 by default
        multiArray[0, 0] = 1;
        multiArray[0, 1] = 2;
        multiArray[0, 2] = 3;
        multiArray[1, 0] = 4;
        multiArray[1, 1] = 5;
        multiArray[1, 2] = 6;
        // You can also declare and initialize a 2D array in one line 
        int[,] anotherMultiArray = { { 1, 2, 3 }, { 4, 5, 6 } }; // 2D array with 2 rows and 3 columns, initialized with values

        // You can get the length of a specific dimension using GetLength method
        Console.WriteLine($"Length of first dimension: {multiArray.GetLength(0)}"); // Output: 2 (number of rows)
        Console.WriteLine($"Length of second dimension: {multiArray.GetLength(1)}"); // Output: 3 (number of columns)

        // You can access elements in a 2D array using two indices
        Console.WriteLine($"Element at (0, 1): {multiArray[0, 1]}"); // Output: 2

        // Changing elements in a 2D array
        multiArray[0, 1] = 10; // Change the element at (0, 1) to 10

        // Accessing elements in a 2D array in for loop
        for (int i = 0; i < multiArray.GetLength(0); i++) // GetLength(0) returns the number of rows
        {
            for (int j = 0; j < multiArray.GetLength(1); j++) // GetLength(1) returns the number of columns
            {
                Console.Write(multiArray[i, j] + " "); // Print each element in the 2D array
            }
            Console.WriteLine(); // New line after each row
        }

    }
}