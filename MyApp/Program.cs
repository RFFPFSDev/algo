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
                Console.Write($"{result}-");
                result.Remove(result.Length-1,1);
                continue;
            }

            result.Append(s[i]);
        }

        return result.ToString();
    }
}