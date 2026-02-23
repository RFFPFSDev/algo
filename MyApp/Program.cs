using System;

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
        Test("aabb", "bbaa", true);
        Test("abcd", "abce", false);
    }

    static void Test(string s1, string s2, bool expected)
    {
        try
        {
            bool result = IsAnagram(s1, s2);
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
        return false;
    }
}