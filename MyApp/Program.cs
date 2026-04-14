class Program
{
    static void Main(string[] args)
    {
        RunTests();
    }

    static void RunTests()
    {
        Test("cde", "abc", 4);              // delete c,d from s1 and a,b from s2
        Test("showman", "woman", 2);        // delete s,h
        Test("aabbcc", "abc", 3);           // remove extra duplicates
        Test("abcc", "abc", 1);             // remove extra duplicates
        Test("abc", "abc", 0);              // already anagrams
        Test("", "abc", 3);                 // delete all from s2
        Test("abc", "", 3);                 // delete all from s1
        Test("xxyyzz", "zzxxyy", 0);        // same chars, different order
    }

    static void Test(string s1, string s2, int expected)
    {
        var result = makingAnagrams(s1, s2);

        if (result == expected)
        {
            Console.WriteLine($"✅: \"{s1}\", \"{s2}\" -> {result}");
        }
        else
        {
            Console.WriteLine($"❌: \"{s1}\", \"{s2}\" | Expected: {expected}, Got: {result}");
        }
    }

    public class Tup
    {
        public int f1 { get; set; }
        public int f2 { get; set; }
    }

    public static int makingAnagrams(string s1, string s2)
    {
        var countF = new Dictionary<char, Tup>();

        foreach (char c in s1)
        {
            if (countF.ContainsKey(c))
            {
                countF[c].f1 += 1;
            }
            else
            {
                countF.Add(c, new Tup() { f1 = 1, f2 = 0 });
            }
        }

        foreach (char c in s2)
        {
            if (countF.ContainsKey(c))
            {
                countF[c].f2 += 1;
            }
            else
            {
                countF.Add(c, new Tup() { f1 = 0, f2 = 1 });
            }
        }

        var result = 0;

        foreach (var cf in countF)
        {
            result += Math.Abs(cf.Value.f1 - cf.Value.f2);
        }

        return result;
    }
}