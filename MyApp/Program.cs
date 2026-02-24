class Program
{
    static void Main()
    {
        // Create a HashSet of integers
        HashSet<int> numbers = new HashSet<int>();

        // Add items
        numbers.Add(10);
        numbers.Add(20);
        numbers.Add(30);

        // Adding a duplicate has no effect
        bool added = numbers.Add(20); // false
        Console.WriteLine($"Trying to add 20 again: {added}");

        Console.WriteLine("\nInitial HashSet:");
        PrintHashSet(numbers);

        // Check if a value exists
        if (numbers.Contains(30))
        {
            Console.WriteLine("\n30 exists in the HashSet");
        }

        // Remove an item
        numbers.Remove(10);
        Console.WriteLine("\nAfter removing 10:");
        PrintHashSet(numbers);

        // Count
        Console.WriteLine("\nTotal items: " + numbers.Count);

        // Union, Intersection, Difference with another HashSet
        HashSet<int> otherNumbers = new HashSet<int>() { 20, 40, 50 };

        // Union
        HashSet<int> union = new HashSet<int>(numbers);
        union.UnionWith(otherNumbers);
        Console.WriteLine("\nUnion of numbers and otherNumbers:");
        PrintHashSet(union);

        // Intersection
        HashSet<int> intersection = new HashSet<int>(numbers);
        intersection.IntersectWith(otherNumbers);
        Console.WriteLine("\nIntersection of numbers and otherNumbers:");
        PrintHashSet(intersection);

        // Difference (numbers - otherNumbers)
        HashSet<int> difference = new HashSet<int>(numbers);
        difference.ExceptWith(otherNumbers);
        Console.WriteLine("\nDifference of numbers and otherNumbers:");
        PrintHashSet(difference);

        // Clear HashSet
        numbers.Clear();
        Console.WriteLine("\nAfter clearing HashSet, count: " + numbers.Count);
    }

    static void PrintHashSet(HashSet<int> set)
    {
        foreach (int num in set)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}