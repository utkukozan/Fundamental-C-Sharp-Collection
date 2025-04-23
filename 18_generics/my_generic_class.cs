namespace _18_generics
{
    class MyGenericClass<T>
    {
        // The generic type parameter T can be replaced with any data type when creating an instance of the class.
        public void Display(T value)
        {
            Console.WriteLine($"Value: {value}");
        }
    }
}
