class Program
{
    static void Main()
    {
        // Create a dictionary
        Dictionary<string, int> students = new Dictionary<string, int>();

        // Add items
        students.Add("Alice", 85);
        students.Add("Bob", 90);
        students["Charlie"] = 78;   // Alternative way to add

        Console.WriteLine("Initial students:");
        PrintDictionary(students);

        // Access values
        Console.WriteLine("\nBob's grade: " + students["Bob"]);

        // Check if key exists
        if (students.ContainsKey("Alice"))
        {
            Console.WriteLine("Alice exists in dictionary.");
        }

        // Check if value exists
        if (students.ContainsValue(90))
        {
            Console.WriteLine("A student has grade 90.");
        }

        // Update value
        students["Alice"] = 95;

        // TryGetValue (safe way)
        if (students.TryGetValue("David", out int grade))
        {
            Console.WriteLine("David's grade: " + grade);
        }
        else
        {
            Console.WriteLine("David not found.");
        }

        // Remove item
        students.Remove("Charlie");

        // Count
        Console.WriteLine("\nTotal students: " + students.Count);

        //  Loop through Keys only
        Console.WriteLine("\nStudent Names:");
        foreach (string name in students.Keys)
        {
            Console.WriteLine(name);
        }

        // Loop through Values only
        Console.WriteLine("\nStudent Grades:");
        foreach (int value in students.Values)
        {
            Console.WriteLine(value);
        }

        // LINQ example (Highest grade)
        int maxGrade = students.Values.Max();
        Console.WriteLine("\nHighest Grade: " + maxGrade);

        // Clear dictionary
        students.Clear();
        Console.WriteLine("\nDictionary cleared.");
        Console.WriteLine("Count after clear: " + students.Count);
    }

    static void PrintDictionary(Dictionary<string, int> dict)
    {
        foreach (var item in dict)
        {
            Console.WriteLine(item.Key + " : " + item.Value);
        }
    }
}