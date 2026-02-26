class Program
{
    static void Main(string[] args)
    {
        RunTests();
    }

    static void RunTests()
    {
        Test(new int[] { 10, 20, 10, 5, 15 }, new int[] { 10, 30, 40, 45, 60 });
        Test(new int[] { 30, 10, 10, 5, 50 }, new int[] { 30, 40, 50, 55, 105 });
        Test(new int[] { }, new int[] { });
        Test(new int[] { 42 }, new int[] { 42 });
        Test(new int[] { 0, 0, 0, 0 }, new int[] { 0, 0, 0, 0 });
        Test(new int[] { -1, -2, -3, -4 }, new int[] { -1, -3, -6, -10 });
        Test(new int[] { 1000, -500, 200, -100 }, new int[] { 1000, 500, 700, 600 });
    }

    static void Test(int[] input, int[] expected)
    {
        var result = PrefixSum(input);

        if (AreEqual(result, expected))
        {
            Console.WriteLine($"✅: PrefixSum([{string.Join(",", input)}]) -> [{string.Join(",", result)}]");
        }
        else
        {
            Console.WriteLine($"❌: Test Failed");
            Console.WriteLine($"   Expected: [{string.Join(",", expected)}]");
            Console.WriteLine($"   Got     : [{string.Join(",", result)}]");
        }
    }

    static bool AreEqual(int[] a, int[] b)
    {
        if (a.Length != b.Length)
            return false;

        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] != b[i])
                return false;
        }

        return true;
    }

    static int[] PrefixSum(int[] arr)
    {
        int len = arr.Length;
        for (int i = 1; i < len; i++)
        {
            arr[i] = arr[i-1] + arr[i];
        }

        return arr;
    }
}