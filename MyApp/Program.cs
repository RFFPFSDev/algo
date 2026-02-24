class Program
{
    static void Main(string[] args)
    {
        RunTests();
    }

    static void RunTests()
    {
        Test(new int[] { 2, 1, 5, 1, 3, 2 }, 3, 9);       // subarray [5,1,3]
        Test(new int[] { 1, 2, 3, 4, 5 }, 2, 9);          // subarray [4,5]
        Test(new int[] { -1, -2, -3, -4 }, 2, -3);        // subarray [-1,-2]
        Test(new int[] { 5, 2, -1, 0, 3 }, 1, 5);         // single element window
        Test(new int[] { 1, 2 }, 3, -1);                  // k > array length, invalid
    }

    static void Test(int[] arr, int k, int expected)
    {
        try
        {
            var result = MaxSumSubarray(arr, k);
            if (result == expected)
            {
                Console.WriteLine($"✅: [{string.Join(",", arr)}], k={k} -> {result}");
            }
            else
            {
                Console.WriteLine($"❌: [{string.Join(",", arr)}], k={k} | Expected: {expected}, Got: {result}");
            }
        }
        catch (NotImplementedException)
        {
            Console.WriteLine("MaxSumSubarray function is not implemented.");
        }
    }

    static int MaxSumSubarray(int[] arr, int k)
    {
    }
}