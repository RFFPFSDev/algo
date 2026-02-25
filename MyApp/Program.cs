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