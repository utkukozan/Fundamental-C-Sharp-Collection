namespace _19_threads;

class Threads
{
    // Threads are used to perform multiple tasks concurrently
    // They are lightweight processes that can run in parallel with other threads
    // Threads are useful for performing tasks that are independent of each other
    static void Main()
    {
        // When starts program, the Main method is executed in the main thread.

        // Now, we will create a new custom thread to perform a task in parallel with the main thread.
        // Create a new custom thread
        Thread thread = new Thread(new ThreadStart(DoWork)); // Create a new custom thread and assign it the DoWork method

        // Start the custom thread
        thread.Start();

        Thread.Sleep(1000); // Sleep for 1 second to allow the custom thread to start
        Console.WriteLine("Test"); // This will run while the MAIN thread is executing.

        thread.IsBackground = true; // Set the thread to be a background thread

        // In this example, the custom thread will print "Test" while the DoWork method is running in a separate thread.
        // The main thread will continue to execute while the custom thread is running.
        // Threads allow us to perform multiple tasks simultaneously.
        // Do not rely on the order of execution between threads.

        //If you want to wait for the thread to finish before continuing, you can use the Join method.
        thread.Join(); // This will block the main thread until the thread has finished executing
        Console.WriteLine("Custom thread has finished executing.");

        // Threads can also be used to perform tasks that require a lot of processing power, such as image processing or data analysis.
        // In these cases, you can use multiple threads to divide the work into smaller tasks and process them in parallel.
        // This can significantly improve the performance of your application.
    }
    static void DoWork()
    {
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Custom thread is working...");
            Thread.Sleep(1000); // Simulate work
        }
    }
}