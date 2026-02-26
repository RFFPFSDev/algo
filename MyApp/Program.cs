class Program
{
    static void Main(string[] args)
    {
        RunTests();
    }

    static void RunTests()
    {
        Test(new int[] { 1, 5, 4, 3 }, 6);
        Test(new int[] { 3, 1, 2, 4, 5 }, 12);
        Test(new int[] { 2, 1, 8, 6, 4, 6, 5, 5 }, 25);
        Test(new int[] { 1, 1 }, 1);
        Test(new int[] { 1, 2, 1 }, 2);
        Test(new int[] { 4, 3, 2, 1, 4 }, 16);
    }

    static void Test(int[] input, int expected)
    {
        var result = MaxWaterContainer(input);

        if (result == expected)
        {
            Console.WriteLine($"✅: MaxWaterContainer([{string.Join(",", input)}]) -> {result}");
        }
        else
        {
            Console.WriteLine($"❌: Test Failed");
            Console.WriteLine($"   Expected: {expected}");
            Console.WriteLine($"   Got     : {result}");
        }
    }

    static int MaxWaterContainer(int[] height)
    {
        int len = height.Length;
        int l = 0;
        int r = len - 1;
        int max = 0;

        while(l < r)
        {
            max = Math.Max(max, (r-l)*Math.Min(height[l],height[r]));

            if (height[l] > height[r])
            {
                r--;
            }
            else
            {
                l++;
            }
        }

        return max;
    }
}