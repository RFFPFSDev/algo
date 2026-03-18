class Program
{
    static void Main()
    {
        // Create a list of integers
        List<int> numbers = new List<int>();

        // Add items
        numbers.Add(10);
        numbers.Add(20);
        numbers.Add(30);
        numbers.Add(40);

        // Add a range of items
        numbers.AddRange(new int[] { 50, 60 });

        Console.WriteLine("Initial list:");
        PrintList(numbers);

        // Access by index
        Console.WriteLine("\nElement at index 2: " + numbers[2]);

        // Update value
        numbers[1] = 25;
        Console.WriteLine("\nAfter updating index 1:");
        PrintList(numbers);

        // Insert value at a specific index
        numbers.Insert(2, 15);
        Console.WriteLine("\nAfter inserting 15 at index 2:");
        PrintList(numbers);

        // Remove by value
        numbers.Remove(40);
        Console.WriteLine("\nAfter removing 40:");
        PrintList(numbers);

        // Remove by index
        numbers.RemoveAt(0);
        Console.WriteLine("\nAfter removing at index 0:");
        PrintList(numbers);

        // Check if value exists
        if (numbers.Contains(25))
        {
            Console.WriteLine("\n25 exists in the list");
        }

        // Find index
        int index = numbers.IndexOf(50);
        Console.WriteLine("Index of 50: " + index);

        // Count
        Console.WriteLine("\nTotal items: " + numbers.Count);

        // Sort list
        numbers.Sort();
        Console.WriteLine("\nAfter sorting:");
        PrintList(numbers);

        // Reverse list
        numbers.Reverse();
        Console.WriteLine("\nAfter reversing:");
        PrintList(numbers);

        // LINQ examples
        int max = numbers.Max();
        int min = numbers.Min();
        int sum = numbers.Sum();
        Console.WriteLine($"\nMax: {max}, Min: {min}, Sum: {sum}");

        // Clear list
        numbers.Clear();
        Console.WriteLine("\nAfter clearing list, count: " + numbers.Count);
    }

    static void PrintList(List<int> list)
    {
        foreach (int num in list)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}