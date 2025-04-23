namespace _15_files;

class Files
{
    // Files are a way to store data on disk.
    // In C#, you can use the System.IO namespace to work with files.
    // You can create, read, write, and delete files using various classes and methods provided in this namespace.
    // The most commonly used classes are File, FileInfo, StreamReader, StreamWriter, and Directory.
    static void Main(string[] args)
    {
        //Create a file
        try
        {
            string filePath = "example.txt"; // File path
            string content = "Hello, World!"; // Content to write to the file
            File.WriteAllText(filePath, content); // Write content to the file
            // Note: If using Visual Studio, the file may be created in the bin/Debug/netx.x directory. (x = 7, 8, etc.)
            Console.WriteLine("File created successfully");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error creating file: {ex.Message}");
        }

        //Check if a file exists
        try
        {
            string filePath = "example.txt"; // File path
            if (File.Exists(filePath)) // Check if the file exists
            {
                Console.WriteLine("File exists");
            }
            else
            {
                Console.WriteLine("File does not exist");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error checking file existence: {ex.Message}");
        }

        //Read a file
        try
        {
            string filePath = "example.txt"; // File path
            string content = File.ReadAllText(filePath); // Read content from the file
            Console.WriteLine($"File content: {content}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error reading file: {ex.Message}");
        }

        //Append to a file
        try
        {
            string filePath = "example.txt"; // File path
            string content = "\nAppended text"; // Content to append to the file
            File.AppendAllText(filePath, content); // Append content to the file
            Console.WriteLine("Content appended successfully");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error appending to file: {ex.Message}");
        }


        //Delete a file
        try
        {
            string filePath = "example.txt"; // File path
            File.Delete(filePath); // Delete the file
            Console.WriteLine("File deleted successfully");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error deleting file: {ex.Message}");
        }

        // Create a directory
        try
        {
            string directoryPath = "exampleDir"; // Directory path
            Directory.CreateDirectory(directoryPath); // Create the directory
            Console.WriteLine("Directory created successfully");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error creating directory: {ex.Message}");
        }

        // List files in current directory
        try
        {
            string directoryPath = "."; // Current directory
            string[] files = Directory.GetFiles(directoryPath); // Get all files in the directory
            Console.WriteLine("Files in directory:");
            foreach (string file in files)
            {
                Console.WriteLine(file); // Print each file name
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error listing files: {ex.Message}");
        }

        // Delete a directory
        try
        {
            string directoryPath = "exampleDir"; // Directory path
            Directory.Delete(directoryPath, true); // Delete the directory and its contents
            Console.WriteLine("Directory deleted successfully");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error deleting directory: {ex.Message}");
        }

        // StreamReader and StreamWriter
        // StreamReader and StreamWriter are used for reading and writing text files.
        // They provide a more efficient way to read and write files compared to File.ReadAllText and File.WriteAllText.
        try
        {
            string filePath = "example.txt"; // File path
            using (StreamWriter writer = new StreamWriter(filePath)) // Create a StreamWriter to write to the file
            {
                writer.WriteLine("Hello, World!"); // Write content to the file
            }
            using (StreamReader reader = new StreamReader(filePath)) // Create a StreamReader to read from the file
            {
                string content = reader.ReadToEnd(); // Read all content from the file
                Console.WriteLine($"File content: {content}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error with StreamReader/StreamWriter: {ex.Message}");
        }

        // FileInfo class
        // FileInfo class provides instance methods for creating, copying, deleting, moving, and opening files.
        // It also provides properties for getting file information such as name, size, and creation time.
        try
        {
            string filePath = "example.txt"; // File path
            FileInfo fileInfo = new FileInfo(filePath); // Create a FileInfo object for the file
            Console.WriteLine($"File name: {fileInfo.Name}"); // Print file name
            Console.WriteLine($"File size: {fileInfo.Length} bytes"); // Print file size
            Console.WriteLine($"File creation time: {fileInfo.CreationTime}"); // Print file creation time
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error with FileInfo: {ex.Message}");
        }

        // DirectoryInfo class
        // DirectoryInfo class provides instance methods for creating, moving, and enumerating through directories and subdirectories.
        // It also provides properties for getting directory information such as name, creation time, and parent directory.
        try
        {
            string directoryPath = "."; // Current directory
            DirectoryInfo directoryInfo = new DirectoryInfo(directoryPath); // Create a DirectoryInfo object for the directory
            Console.WriteLine($"Directory name: {directoryInfo.Name}"); // Print directory name
            Console.WriteLine($"Directory creation time: {directoryInfo.CreationTime}"); // Print directory creation time
            Console.WriteLine("Subdirectories:");
            foreach (DirectoryInfo subDir in directoryInfo.GetDirectories()) // Get all subdirectories
            {
                Console.WriteLine(subDir.Name); // Print each subdirectory name
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error with DirectoryInfo: {ex.Message}");
        }

        // FileStream class
        // FileStream class provides a way to read from and write to files using streams.
        // It allows for more control over file access and buffering.
        try
        {
            string filePath = "example.txt"; // File path
            using (FileStream fileStream = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.ReadWrite)) // Create a FileStream to read and write to the file
            {
                byte[] data = System.Text.Encoding.UTF8.GetBytes("Hello, World!"); // Convert string to byte array
                fileStream.Write(data, 0, data.Length); // Write byte array to the file
                fileStream.Seek(0, SeekOrigin.Begin); // Move the file pointer to the beginning of the file
                byte[] buffer = new byte[1024]; // Buffer for reading data
                int bytesRead = fileStream.Read(buffer, 0, buffer.Length); // Read data from the file
                string content = System.Text.Encoding.UTF8.GetString(buffer, 0, bytesRead); // Convert byte array to string
                Console.WriteLine($"File content: {content}"); // Print file content
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error with FileStream: {ex.Message}");
        }

        // Delete a file using FileInfo
        try
        {
            string filePath = "example.txt"; // File path
            FileInfo fileInfo = new FileInfo(filePath); // Create a FileInfo object for the file
            if (fileInfo.Exists) // Check if the file exists
            {
                fileInfo.Delete(); // Delete the file
                Console.WriteLine("File deleted successfully");
            }
            else
            {
                Console.WriteLine("File does not exist");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error deleting file using FileInfo: {ex.Message}");
        }

        // StreamReader and StreamWriter with using statement
        // The using statement ensures that the StreamReader and StreamWriter are disposed of properly after use.
        try
        {
            string filePath = "example.txt"; // File path
            using (StreamWriter writer = new StreamWriter(filePath)) // Create a StreamWriter to write to the file
            {
                writer.WriteLine("Hello, World!"); // Write content to the file
            }
            using (StreamReader reader = new StreamReader(filePath)) // Create a StreamReader to read from the file
            {
                string content = reader.ReadToEnd(); // Read all content from the file
                Console.WriteLine($"File content: {content}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error with StreamReader/StreamWriter using statement: {ex.Message}");
        }

        // Delete file again
        try
        {
            string filePath = "example.txt"; // File path
            File.Delete(filePath); // Delete the file
            Console.WriteLine("File deleted successfully");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error deleting file: {ex.Message}");
        }
    }
}