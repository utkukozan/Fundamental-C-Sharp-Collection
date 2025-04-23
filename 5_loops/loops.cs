namespace _5_loops;

class Loops
{
    static void Main()
    {
        // In C#, you can use loops to execute a block of code repeatedly based on a condition. The most common types of loops are for, foreach, while, and do-while loops.

        // for loop
        for (int i = 0; i < 5; i++) // Initialization; Condition; Increment
        {
            // It will print "Hello World" 5 times, from 0 to 4. When i = 5, the loop will stop.
            Console.WriteLine("For Loop Hello World Iteration : " + i);
        }

        // foreach loop
        string[] names = ["Alice", "Bob", "Charlie"];
        foreach (string name in names) // Iterates through each element in the array
        {
            // It will print "Hello World" for each name in the array.
            Console.WriteLine("Foreach Loop Hello World : " + name);
        }

        // while loop
        int j = 0;
        while (j < 5) // Condition
        {
            // It will print "Hello World" 5 times, from 0 to 4. When j = 5, the loop will stop.
            Console.WriteLine("While Loop Hello World Iteration : " + j);
            j++;
        }

        // do-while loop
        int k = 0;
        do // Firstly, it will execute the block of code, then check the condition.
        {
            // It will print "Hello World" 5 times, from 0 to 4. When k = 5, the loop will stop.
            Console.WriteLine("Do-While Loop Hello World Iteration : " + k);
            k++;
        } while (k < 5);

        // break statement
        for (int l = 0; l < 5; l++)
        {
            if (l == 3)
            {
                // It will break the loop when l = 3.
                break;
            }
            Console.WriteLine("Break Statement Hello World Iteration : " + l); // 0, 1, 2
        }

        // continue statement
        for (int m = 0; m < 5; m++)
        {
            if (m == 3)
            {
                // It will skip the current iteration when m = 3.
                continue;
            }
            Console.WriteLine("Continue Statement Hello World Iteration : " + m); // 0, 1, 2, 4
        }

        // goto statement (not recommended)
        // Note: Goto statements are generally discouraged in modern programming as they can make code harder to read and maintain and bug-prone.
        int n = 0;
    start: // Label
        if (n < 5)
        {
            Console.WriteLine("Goto Statement Hello World Iteration : " + n);
            n++;
            goto start; // Jumps to the label
        }
        // return statement
        Console.WriteLine("End of Loops");

        // Nested Loop example (Triangle Pattern)
        for (int i = 0; i < 5; i++)
        {
            for (int a = 0; a <= i; a++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
    }
}