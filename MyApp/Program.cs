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
        Test("pwwkew", "wke");
        Test("", "");
        Test("abcdef", "abcdef");
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
    }
}