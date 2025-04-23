using System.Collections;

namespace _17_collections;

class Collections
{
    // Collections are used to store multiple values in a single variable.
    // They are dynamic in size and can grow or shrink as needed.
    // Collections are part of the System.Collections namespace.

    static void Main(string[] args)
    {
        // Normal array: fixed size, static
        string[] names = new string[5];
        names[0] = "John";
        names[1] = "Jane";
        names[2] = "Jack";
        names[3] = "Jill";
        names[4] = "Joe";
        // Display the array
        DisplayArray(names);

        // List: dynamic size, static
        List<string> nameList = new List<string>();
        nameList.Add("John");
        nameList.Add("Jane");
        nameList.Add("Jack");
        nameList.Add("Jill");
        nameList.Add("Joe");
        // Display the list
        DisplayList(nameList);

        // Dictionary: key-value pairs, static, fast lookup
        Dictionary<int, string> nameDict = new Dictionary<int, string>();
        nameDict.Add(1, "John");
        nameDict.Add(2, "Jane");
        nameDict.Add(3, "Jack");
        nameDict.Add(4, "Jill");
        nameDict.Add(5, "Joe");
        // Display the dictionary
        DisplayDictionary(nameDict);

        // Stack: LIFO (Last In First Out), static
        Stack<string> nameStack = new Stack<string>();
        nameStack.Push("John");
        nameStack.Push("Jane");
        nameStack.Push("Jack");
        nameStack.Push("Jill");
        nameStack.Push("Joe");
        // Display the stack
        DisplayStack(nameStack);

        // Queue: FIFO (First In First Out), static
        Queue<string> nameQueue = new Queue<string>();
        nameQueue.Enqueue("John");
        nameQueue.Enqueue("Jane");
        nameQueue.Enqueue("Jack");
        nameQueue.Enqueue("Jill");
        nameQueue.Enqueue("Joe");
        // Display the queue
        DisplayQueue(nameQueue);

        // HashSet: unordered collection of unique elements, static
        HashSet<string> nameHashSet = new HashSet<string>();
        nameHashSet.Add("John");
        nameHashSet.Add("Jane");
        nameHashSet.Add("Jack");
        nameHashSet.Add("Jill");
        nameHashSet.Add("Joe");
        // Display the hash set
        DisplayHashSet(nameHashSet);

        // SortedList: key-value pairs, sorted by key, static
        SortedList<int, string> nameSortedList = new SortedList<int, string>();
        nameSortedList.Add(1, "John");
        nameSortedList.Add(2, "Jane");
        nameSortedList.Add(3, "Jack");
        nameSortedList.Add(4, "Jill");
        nameSortedList.Add(5, "Joe");
        // Display the sorted list
        DisplaySortedList(nameSortedList);

        // LinkedList: doubly linked list, static, allows insertion and deletion at both ends
        LinkedList<string> nameLinkedList = new LinkedList<string>();
        nameLinkedList.AddLast("John");
        nameLinkedList.AddLast("Jane");
        nameLinkedList.AddLast("Jack");
        nameLinkedList.AddLast("Jill");
        nameLinkedList.AddLast("Joe");
        // Display the linked list
        DisplayLinkedList(nameLinkedList);

        // ArrayList: dynamic size, static, can store different data types
        ArrayList nameArrayList = new ArrayList();
        nameArrayList.Add("John");
        nameArrayList.Add("Jane");
        nameArrayList.Add("Jack");
        nameArrayList.Add("Jill");
        nameArrayList.Add("Joe");
        // Display the array list
        DisplayArrayList(nameArrayList);

        // BitArray: a collection of bits, static
        BitArray nameBitArray = new BitArray(5);
        nameBitArray[0] = true;
        nameBitArray[1] = false;
        nameBitArray[2] = true;
        nameBitArray[3] = false;
        nameBitArray[4] = true;
        // Display the bit array
        DisplayBitArray(nameBitArray);

        // Hashtable: key-value pairs, unordered, static
        Hashtable nameHashtable = new Hashtable();
        nameHashtable.Add(1, "John");
        nameHashtable.Add(2, "Jane");
        nameHashtable.Add(3, "Jack");
        nameHashtable.Add(4, "Jill");
        nameHashtable.Add(5, "Joe");
        // Display the hashtable
        DisplayHashtable(nameHashtable);

    }

    static void DisplayArray(string[] names)
    {
        Console.WriteLine("Array");
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }
        Console.WriteLine("_____");
    }

    static void DisplayList(List<string> names)
    {
        Console.WriteLine("List");
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }
        Console.WriteLine("_____");
    }

    static void DisplayDictionary(Dictionary<int, string> names)
    {
        Console.WriteLine("Dictionary");
        foreach (KeyValuePair<int, string> kvp in names)
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
        }
        Console.WriteLine("_____");
    }

    static void DisplayStack(Stack<string> names)
    {
        Console.WriteLine("Stack");
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }
        Console.WriteLine("_____");
    }

    static void DisplayQueue(Queue<string> names)
    {
        Console.WriteLine("Queue");
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }
        Console.WriteLine("_____");
    }

    static void DisplayHashSet(HashSet<string> names)
    {
        Console.WriteLine("HashSet");
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }
        Console.WriteLine("_____");
    }

    static void DisplaySortedList(SortedList<int, string> names)
    {
        Console.WriteLine("SortedList");
        foreach (KeyValuePair<int, string> kvp in names)
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
        }
        Console.WriteLine("_____");
    }

    static void DisplayLinkedList(LinkedList<string> names)
    {
        Console.WriteLine("LinkedList");
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }
        Console.WriteLine("_____");
    }

    static void DisplayArrayList(ArrayList names)
    {
        Console.WriteLine("ArrayList");
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }
        Console.WriteLine("_____");
    }

    static void DisplayBitArray(BitArray names)
    {
        Console.WriteLine("BitArray");
        foreach (bool bit in names)
        {
            Console.WriteLine(bit);
        }
        Console.WriteLine("_____");
    }

    static void DisplayHashtable(Hashtable names)
    {
        Console.WriteLine("Hashtable");
        foreach (DictionaryEntry entry in names)
        {
            Console.WriteLine($"{entry.Key}: {entry.Value}");
        }
        Console.WriteLine("_____");
    }
}