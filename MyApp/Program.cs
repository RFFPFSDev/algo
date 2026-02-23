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
        Test("aabb", "baa", false);
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
        var lettersS1 = new Dictionary<char,int>();
        var lettersS2 = new Dictionary<char,int>();

        foreach(char c in s1)
        {
            if (lettersS1.ContainsKey(c))
            {
                lettersS1[c]++;
            }
            else
            {
                lettersS1.Add(c,1);
            }
        }

        foreach(char c in s2)
        {
            if (lettersS2.ContainsKey(c))
            {
                lettersS2[c]++;
            }
            else
            {
                lettersS2.Add(c,1);
            }
        }

        foreach(char c in lettersS1.Keys)
        {
            if(!lettersS2.ContainsKey(c) || lettersS1[c] != lettersS2[c])
            {
                return false;
            } 
        }

        return true;
    }
}