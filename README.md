## Prerequisites:

### Math

```cs
class Program
{
    static void Main()
    {  
        Console.WriteLine($"17 % 5 = {17 % 5}");
        Console.WriteLine($"8 is even? {8 % 2 == 0}");
        Console.WriteLine($"9 is odd? {9 % 2 != 0}");
        double division = 5.0 / 2.0;
        int truncated = (int)division;
        Console.WriteLine($"5.0 / 2.0 = {division}");
        Console.WriteLine($"After casting to int: {truncated}");
        double division2 = 5 / 2;
        Console.WriteLine($"5 / 2 = {division2}");
        double division3 = ((double)5) / 2;
        Console.WriteLine($"((double)5) / 2 = {division3}");
        int x = 10;
        int y = 25;
        Console.WriteLine($"X,Y={x},{y}");
        Console.WriteLine($"Min: {Math.Min(x, y)}");
        Console.WriteLine($"Max: {Math.Max(x, y)}");
        Console.WriteLine($"Floor(4.1) = {Math.Floor(4.1)}");
        Console.WriteLine($"Floor(4.9) = {Math.Floor(4.9)}");
        Console.WriteLine($"Ceiling(4.1) = {Math.Ceiling(4.1)}");
        Console.WriteLine($"Ceiling(4.9) = {Math.Ceiling(4.9)}");
        Console.WriteLine($"Round(4.3) = {Math.Round(4.3)}");
        Console.WriteLine($"Round(4.5) = {Math.Round(4.5)}");
        Console.WriteLine($"Round(4.6) = {Math.Round(4.6)}");
    }
}
```

```
17 % 5 = 2
8 is even? True
9 is odd? True
5.0 / 2.0 = 2.5
After casting to int: 2
5 / 2 = 2
((double)5) / 2 = 2.5
X,Y=10,25
Min: 10
Max: 25
Floor(4.1) = 4
Floor(4.9) = 4
Ceiling(4.1) = 5
Ceiling(4.9) = 5
Round(4.3) = 4
Round(4.5) = 4
Round(4.6) = 5
```

### string

* string is immutable — once created, it cannot be changed.
* Every “change” creates a NEW string.

```cs
string name = "John";
name[0] = 'B';   // ❌ Error
char firstLetter = name[0];
name = "Bob"; // Creating a new string "Bob". Making name reference the new object (string "Bob"). The old "John" may later be garbage collected
```

* Use StringBuilder, if you need to modify text frequently

```cs
using System.Text;

StringBuilder sb = new StringBuilder("Hello");
sb[0] = 'B';        // ✅ Allowed
sb.Append(" World");

string result = sb.ToString();
```

### Array (T[])

* Fixed-size collection

```cs
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
```

### List<T>

* Ordered, index-based dynamic array
* Allows duplicates
* Fast access by index

```cs
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
```

### HashSet<T>

* Stores unique elements
* No guaranteed order
* Very fast lookup

```cs
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
```

### Dictionary

* Key–value pairs
* Fast lookups by key
* Keys must be unique

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

### Frequency Count

IsAnagram

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

First Non-Repeating Character

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

### Sliding window

Find maximum sum of subarray of size k

```cs
class Program
{
    static void Main(string[] args)
    {
        RunTests();
    }

    static void RunTests()
    {
        Test(new int[] { 2, 1, 2, 1, 3, 1, 2, 1 }, 3, 6); // subarray [3,1,2]
        Test(new int[] { 2, 1, 5, 1, 3, 2 }, 3, 9);       // subarray [5,1,3]
        Test(new int[] { 1, 2, 3, 4, 5 }, 2, 9);          // subarray [4,5]
        Test(new int[] { -1, -2, -3, -4 }, 2, -3);        // subarray [-1,-2]
        Test(new int[] { -4, -3, -2, -1 }, 3, -6);        // subarray [-3,-2,-1]
        Test(new int[] { 5, 2, -1, 0, 3 }, 1, 5);         // single element window
        Test(new int[] { 1, 2 }, 3, -1);                  // k > array length, invalid
    }

    static void Test(int[] arr, int k, int expected)
    {
        var result = MaxSumSubarray(arr, k);
        if (result == expected)
        {
            Console.WriteLine($"✅: [{string.Join(",", arr)}], k={k} -> {result}");
        }
        else
        {
            Console.WriteLine($"❌: [{string.Join(",", arr)}], k={k} | Expected: {expected}, Got: {result}");
        }
    }

    static int MaxSumSubarray(int[] arr, int k)
    {
        if (k > arr.Length)
        {
            return -1;
        }

        if (k == 1)
        {
           return arr.Max();
        }

        int sum = 0;
        for (int i=0; i < k; i++)
        {
            sum+=arr[i];
        }
        int maxSum = sum;

        for (int a = 0; a < arr.Length - k; a++)
        {
            sum+=arr[a + k]-arr[a];
            if (sum > maxSum)
            {
                maxSum = sum;
            }
        }

        return maxSum;
    }
}
```

Longest substring that contains only distinct characters

```cs
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        RunTests();
    }

    static void RunTests()
    {
        Test("abcabcbb", "abc");
        Test("bbbbb", "b");
        Test("aa", "a");
        Test("ab", "ab");
        Test("c", "c");
        Test("pwwkew", "wke");
        Test("wpwkew", "pwke");
        Test("", "");
        Test("abcdef", "abcdef");
        Test("abccefg", "cefg");
    }

    static void Test(string input, string expected)
    {
        var result = LongestDistinctSubstring(input);
        if (result == expected)
        {
            Console.WriteLine($"✅: \"{input}\" -> \"{result}\"");
        }
        else
        {
            Console.WriteLine($"❌: \"{input}\" | Expected: \"{expected}\", Got: \"{result}\"");
        }
    }

    static string LongestDistinctSubstring(string s)
    {
        int len = s.Length;
        if (len <= 1)
        {
            return s;
        }

        int l = 0;
        int startIndex = l;
        int maxLength = 1;
        var unique = new HashSet<char>();
        unique.Add(s[l]);
        int r = 1;

        while (r < len)
        {
            if (unique.Add(s[r]))
            {
                if (maxLength < r - l + 1)
                {
                    maxLength = r - l + 1;
                    startIndex = l;
                }
                r++;
                continue;
            }

            unique.Remove(s[l]);
            l++;
        }

        return s.Substring(startIndex, maxLength);
    }
}
```

### Stack

Repeatedly remove adjacent duplicate characters until no duplicates remain

```cs
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        RunTests();
    }

    static void RunTests()
    {
        Test("abbaca", "ca");
        Test("azxxzy", "ay");
        Test("aabbcc", "");
        Test("abc", "abc");
        Test("aaaa", "");
        Test("abba", "");
        Test("aabccbadd", "a");
        Test("", "");
        Test("a", "a");
        Test("aaabccddd", "abd");
    }

    static void Test(string input, string expected)
    {
        var result = RemoveAdjacentDuplicates(input);

        if (result == expected)
        {
            Console.WriteLine($"✅: \"{input}\" -> \"{result}\"");
        }
        else
        {
            Console.WriteLine($"❌: \"{input}\" | Expected: \"{expected}\", Got: \"{result}\"");
        }
    }

    static string RemoveAdjacentDuplicates(string s)
    {
        int len = s.Length;
        if (len <= 1)
        {
            return s;
        }

        var result = new StringBuilder();

        for (int i=0; i < len; i++)
        {
            if (result.Length > 0 && s[i] == result[result.Length-1])
            {
                result.Remove(result.Length-1,1);
                continue;
            }

            result.Append(s[i]);
        }

        return result.ToString();
    }
}
```

### Dynamic Programming

Fibonacci

```cs
class Program
{
    static void Main(string[] args)
    {
        RunTests();
    }

    static void RunTests()
    {
        Test(0, 0);
        Test(1, 1);
        Test(2, 1);
        Test(3, 2);
        Test(4, 3);
        Test(5, 5);
        Test(6, 8);
        Test(7, 13);
        Test(8, 21);
        Test(9, 34);
        Test(10, 55);
        Test(15, 610);
        Test(20, 6765);
    }

    static void Test(int n, int expected)
    {
        var result = Fibonacci(n);

        if (result == expected)
        {
            Console.WriteLine($"✅: Fibonacci({n}) -> {result}");
        }
        else
        {
            Console.WriteLine($"❌: Fibonacci({n}) | Expected: {expected}, Got: {result}");
        }
    }

    static int Fibonacci(int n)
    {
        if (n <= 1)
        {
            return n;
        }

        var previousResult = new int[2];
        previousResult[0] = 0;
        previousResult[1] = 1;

        for (int i=2; i <= n; i++)
        {
            int temp = previousResult[1] + previousResult[0];
            previousResult[0] = previousResult[1];
            previousResult[1] = temp;
        }

        return previousResult[1];
    }
}
```

### Math

Sum from 1 to n

```cs
class Program
{
    static void Main(string[] args)
    {
        RunTests();
    }

    static void RunTests()
    {
        Test(0, 0);
        Test(1, 1);
        Test(2, 3);
        Test(3, 6);
        Test(4, 10);
        Test(5, 15);
        Test(6, 21);
        Test(7, 28);
        Test(8, 36);
        Test(9, 45);
        Test(10, 55);
        Test(15, 120);
        Test(20, 210);
    }

    static void Test(int n, int expected)
    {
        var result = PrefixSum(n);

        if (result == expected)
        {
            Console.WriteLine($"✅: PrefixSum({n}) -> {result}");
        }
        else
        {
            Console.WriteLine($"❌: PrefixSum({n}) | Expected: {expected}, Got: {result}");
        }
    }

    // 0+1+2+...+n
    // 1 2 3 4 5 6 7 8 9
    static int PrefixSum(int n)
    {
        if (n <= 1)
        {
            return n;
        }

        var middlevalue = n % 2 == 1 ? (n+1)/2 : n/2;
        return n % 2 == 1 ?
            middlevalue + (n+1)*(middlevalue - 1) :
            (n+1)*middlevalue;
    }
}
```

### Prefix Sum

Prefix Sum Array

```cs
class Program
{
    static void Main(string[] args)
    {
        RunTests();
    }

    static void RunTests()
    {
        Test(new int[] { 10, 20, 10, 5, 15 }, new int[] { 10, 30, 40, 45, 60 });
        Test(new int[] { 30, 10, 10, 5, 50 }, new int[] { 30, 40, 50, 55, 105 });
        Test(new int[] { }, new int[] { });
        Test(new int[] { 42 }, new int[] { 42 });
        Test(new int[] { 0, 0, 0, 0 }, new int[] { 0, 0, 0, 0 });
        Test(new int[] { -1, -2, -3, -4 }, new int[] { -1, -3, -6, -10 });
        Test(new int[] { 1000, -500, 200, -100 }, new int[] { 1000, 500, 700, 600 });
    }

    static void Test(int[] input, int[] expected)
    {
        var result = PrefixSum(input);

        if (AreEqual(result, expected))
        {
            Console.WriteLine($"✅: PrefixSum([{string.Join(",", input)}]) -> [{string.Join(",", result)}]");
        }
        else
        {
            Console.WriteLine($"❌: Test Failed");
            Console.WriteLine($"   Expected: [{string.Join(",", expected)}]");
            Console.WriteLine($"   Got     : [{string.Join(",", result)}]");
        }
    }

    static bool AreEqual(int[] a, int[] b)
    {
        if (a.Length != b.Length)
            return false;

        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] != b[i])
                return false;
        }

        return true;
    }

    static int[] PrefixSum(int[] arr)
    {
        int len = arr.Length;
        for (int i = 1; i < len; i++)
        {
            arr[i] = arr[i-1] + arr[i];
        }

        return arr;
    }
}
```

### Two Pointers

Container with Most Water

```cs
class Program
{
    static void Main(string[] args)
    {
        RunTests();
    }

    static void RunTests()
    {
        Test(new int[] { 1, 5, 4, 3 }, 6);
        Test(new int[] { 3, 1, 2, 4, 5 }, 12);
        Test(new int[] { 2, 1, 8, 6, 4, 6, 5, 5 }, 25);
        Test(new int[] { 1, 1 }, 1);
        Test(new int[] { 1, 2, 1 }, 2);
        Test(new int[] { 4, 3, 2, 1, 4 }, 16);
    }

    static void Test(int[] input, int expected)
    {
        var result = MaxWaterContainer(input);

        if (result == expected)
        {
            Console.WriteLine($"✅: MaxWaterContainer([{string.Join(",", input)}]) -> {result}");
        }
        else
        {
            Console.WriteLine($"❌: Test Failed");
            Console.WriteLine($"   Expected: {expected}");
            Console.WriteLine($"   Got     : {result}");
        }
    }

    static int MaxWaterContainer(int[] height)
    {
        int len = height.Length;
        int l = 0;
        int r = len - 1;
        int max = 0;

        while(l < r)
        {
            max = Math.Max(max, (r-l)*Math.Min(height[l],height[r]));

            if (height[l] > height[r])
            {
                r--;
            }
            else
            {
                l++;
            }
        }

        return max;
    }
}
```

### Sorting



```cs
```

### Binary Search



```cs
```

## References:

https://www.geeksforgeeks.org/dsa/top-100-data-structure-and-algorithms-dsa-interview-questions-topic-wise/