class Program
{
    static void Main()
    {
        // Create an array (fixed size)
        var numbers = new int[5];

        // Assign/Modify values by index
        numbers[0] = 10;
        numbers[1] = 5;
        numbers[2] = 8;
        // Arrays are automatically initialized with default values. numbers[3] is 0
        numbers[4] = 15;

        Console.WriteLine("Initial array:");
        PrintArray(numbers);

        // Access value by index
        Console.WriteLine("\nElement at index 2: " + numbers[2]);

        // Length
        Console.WriteLine("Array length: " + numbers.Length);

        // Check if value exists
        bool contains20 = numbers.Contains(15);
        Console.WriteLine("\nContains 15? " + contains20);

        // Find index of value
        int index = Array.IndexOf(numbers, 15);
        Console.WriteLine("Index of 15: " + index);

        // Sort array
        Array.Sort(numbers);
        Console.WriteLine("\nAfter sorting:");
        PrintArray(numbers);

        // Reverse array
        Array.Reverse(numbers);
        Console.WriteLine("\nAfter reversing:");
        PrintArray(numbers);

        // Max / Min (LINQ)
        int max = numbers.Max();
        int min = numbers.Min();
        Console.WriteLine("\nMax value: " + max);
        Console.WriteLine("Min value: " + min);

        // Resize array
        Array.Resize(ref numbers, 7);
        numbers[5] = 99;
        numbers[6] = 100;

        Console.WriteLine("\nAfter resizing:");
        PrintArray(numbers);

        // Clear array (sets values to default)
        Array.Clear(numbers, 0, numbers.Length);
        Console.WriteLine("\nAfter clearing:");
        PrintArray(numbers);
    }

    static void PrintArray(int[] array)
    {
        foreach (int number in array)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();
    }
}