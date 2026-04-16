class Program
{
    static void Main(string[] args)
    {
        RunTests();
    }

    static void RunTests()
    {
        Test("{[()]}", "YES");
        Test("{[(])}", "NO");
        Test("{{[[(())]]}}", "YES");
        Test("()", "YES");
        Test(")(", "NO");
        Test("([)]", "NO");
        Test("", "YES");
        Test("[", "NO");
        Test("]", "NO");
    }

    static void Test(string input, string expected)
    {
        var result = IsBalanced(input);

        if (result == expected)
        {
            Console.WriteLine($"✅: \"{input}\" -> \"{result}\"");
        }
        else
        {
            Console.WriteLine($"❌: \"{input}\" | Expected: \"{expected}\", Got: \"{result}\"");
        }
    }

    static string IsBalanced(string s)
    {
        int len = s.Length;

        if (len == 0)
        {
            return "YES";
        }

        var opposites = new Dictionary<char,char>();
        opposites.Add('}','{');
        opposites.Add(']','[');
        opposites.Add(')','(');

        var stack = new Stack<char>();
        stack.Push(s[0]);

        for (int i = 1; i < len; i++)
        {
            if (stack.Count > 0 && opposites.ContainsKey(s[i]) && opposites[s[i]] == stack.First())
            {
                stack.Pop();
                continue;
            }

            stack.Push(s[i]);
        }

        return stack.Count == 0 ? "YES" : "NO";
    }
}