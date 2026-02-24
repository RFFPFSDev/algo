## Prerequisites:

### Dictionary

```cs
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
```

## Algorithms

### IsAnagram

```cs
class Program
{
    static void Main(string[] args)
    {
        RunTests();
    }

    static void RunTests()
    {
        Test("listen", "silent", true);
        Test("triangle", "integral", true);
        Test("apple", "papel", true);
        Test("rat", "car", false);
        Test("aabb", "baa", false);
        Test("aaabbb", "bbaaaa", false);
        Test("bbaaaa", "aaabbb", false);
        Test("aabb", "bbaa", true);
        Test("abcd", "abce", false);
    }

    static void Test(string s1, string s2, bool expected)
    {
        try
        {
            var result = IsAnagram(s1, s2);
            if (result == expected)
            {
                Console.WriteLine($"✅: \"{s1}\" & \"{s2}\"");
            }
            else
            {
                Console.WriteLine($"❌: \"{s1}\" & \"{s2}\" | Expected: {expected}, Got: {result}");
            }
        }
        catch (NotImplementedException)
        {
            Console.WriteLine("IsAnagram function is not implemented.");
        }
    }

    static bool IsAnagram(string s1, string s2)
    {
        if (s1.Length != s2.Length) return false;

        var letters = new Dictionary<char,int>();

        foreach(char c in s1)
        {
            if (letters.ContainsKey(c))
            {
                letters[c]++;
            }
            else
            {
                letters.Add(c,1);
            }
        }

        foreach(char c in s2)
        {
            if (!letters.ContainsKey(c) || letters[c] == 0)
            {
               return false; 
            }

            letters[c]--;
        }

        return true;
    }
}
```

### First Non-Repeating Character

```cs
class Program
{
    static void Main(string[] args)
    {
        RunTests();
    }

    static void RunTests()
    {
        Test("leetcode", 0);
        Test("loveleetcode", 2);
        Test("aabb", -1);
        Test("abcabcde", 6);
        Test("", -1);
    }

    static void Test(string input, int expected)
    {
        try
        {
            var result = FirstUniqueChar(input);
            if (result == expected)
            {
                Console.WriteLine($"✅: \"{input}\" -> {result}");
            }
            else
            {
                Console.WriteLine($"❌: \"{input}\" | Expected: {expected}, Got: {result}");
            }
        }
        catch (NotImplementedException)
        {
            Console.WriteLine("FirstUniqueChar function is not implemented.");
        }
    }

    static int FirstUniqueChar(string s)
    {
        var count = new Dictionary<char, int>();

        foreach (char c in s)
        {
            count[c] = count.TryGetValue(c, out int v) ? v + 1 : 1;
        }

        for (int i = 0; i < s.Length; i++)
        {
            if (count[s[i]] == 1)
                return i;
        }

        return -1;
    }
}
```