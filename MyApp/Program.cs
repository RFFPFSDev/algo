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
        Test("aaabbb", "bbaaaa", false);
        Test("bbaaaa", "aaabbb", false);
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