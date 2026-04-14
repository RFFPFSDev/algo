class Program
{
    static void Main(string[] args)
    {
        RunTests();
    }

    static void RunTests()
    {
        Test(new int[] { 2, 7, 11, 15 }, 9, true);     // 2 + 7
        Test(new int[] { 15, 11, 7, 2 }, 9, true);     // 2 + 7
        Test(new int[] { 3, 2, 4 }, 6, true);          // 2 + 4
        Test(new int[] { 3, 3 }, 6, true);             // 3 + 3
        Test(new int[] { 1, 2, 3, 4 }, 8, false);      // no pair
        Test(new int[] { -1, -2, -3, -4 }, -6, true);  // -2 + -4
        Test(new int[] { 0, 4, 3, 0 }, 0, true);       // 0 + 0
        Test(new int[] { 5 }, 5, false);               // single element
        Test(new int[] { }, 0, false);                 // empty array
    }

    static void Test(int[] nums, int target, bool expected)
    {
        var result = HasPairWithSum(nums, target);

        if (result == expected)
        {
            Console.WriteLine($"✅: [{string.Join(", ", nums)}], target={target} -> {result}");
        }
        else
        {
            Console.WriteLine($"❌: [{string.Join(", ", nums)}], target={target} | Expected: {expected}, Got: {result}");
        }
    }

    public static bool HasPairWithSum(int[] nums, int target)
    {
        int len = nums.Length;
        if (nums.Length < 2)
        {
            return false;
        }

        for (int i=0; i < len; i++)
        {
            for (int j=i+1; j < len; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    return true;
                }
            }
        }

        return false;
    }
}