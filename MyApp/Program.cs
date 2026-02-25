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
        Test("aabccbadd", "d");
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
    }
}