class Program
{
    static void Main(string[] args)
    {
        RunTests();
    }

    static void RunTests()
    {
        Test(
            new List<string> { "give", "me", "one", "grand", "today", "night" },
            new List<string> { "give", "one", "grand", "today" },
            "Yes"
        );

        Test(
            new List<string> { "two", "times", "three", "is", "not", "four" },
            new List<string> { "two", "times", "two", "is", "four" },
            "No"
        );

        Test(
            new List<string> { "Hello", "world" },
            new List<string> { "hello" },
            "No"   // "Hello" != "hello"
        );

        Test(
            new List<string> { "HELLO", "world" },
            new List<string> { "HELLO" },
            "Yes"
        );

        Test(
            new List<string> { "a", "B", "c" },
            new List<string> { "A" },
            "No"
        );

        Test(
            new List<string> { "hello", "hello", "world" },
            new List<string> { "hello", "world" },
            "Yes"
        );

        Test(
            new List<string> { "hello", "world" },
            new List<string> { "hello", "hello" },
            "No"
        );

        Test(
            new List<string> { "a", "a", "a", "b" },
            new List<string> { "a", "a", "b" },
            "Yes"
        );

        Test(
            new List<string> { "this", "is", "a", "test", "test" },
            new List<string> { "test", "test" },
            "Yes"
        );

        Test(
            new List<string> { "this", "is", "a", "test" },
            new List<string> { "test", "test" },
            "No"
        );


        Test(
            new List<string> { },
            new List<string> { "word" },
            "No"
        );

        Test(
            new List<string> { "word" },
            new List<string> { },
            "Yes"
        );

        Test(
            new List<string> { "repeat" },
            new List<string> { "repeat", "repeat" },
            "No"
        );
    }

    static void Test(List<string> magazine, List<string> note, string expected)
    {
        var result = checkMagazine(magazine, note);

        if (result == expected)
        {
            Console.WriteLine($"✅: [{string.Join(" ", note)}] -> {result}");
        }
        else
        {
            Console.WriteLine($"❌: [{string.Join(" ", note)}] | Expected: {expected}, Got: {result}");
        }
    }

    public static string checkMagazine(List<string> magazine, List<string> note)
    {
        var mf = new Dictionary<string, int>();

        foreach (string s in magazine)
        {
            if (!mf.TryAdd(s, 1))
            {
                mf[s] += 1;
            }
        }

        foreach (string s in note)
        {
            if (mf.ContainsKey(s) && mf[s] > 0)
            {
                mf[s] -= 1;
            }
            else
            {
                return "No";
            }
        }

        return "Yes";
    }
}