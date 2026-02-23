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
        return 0;
    }
}