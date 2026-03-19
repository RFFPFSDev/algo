class Program
{
    static void Main(string[] args)
    {
        RunTests();
    }

    static void RunTests()
    {
        Test(new int[] { 2, 1, 2, 1, 3, 1, 2, 1 }, 3, 6); // subarray [3,1,2]
        Test(new int[] { 2, 1, 5, 1, 3, 2 }, 3, 9);       // subarray [5,1,3]
        Test(new int[] { 1, 2, 3, 4, 5 }, 2, 9);          // subarray [4,5]
        Test(new int[] { -1, -2, -3, -4 }, 2, -3);        // subarray [-1,-2]
        Test(new int[] { -4, -3, -2, -1 }, 3, -6);        // subarray [-3,-2,-1]
        Test(new int[] { 5, 2, -1, 0, 3 }, 1, 5);         // single element window
    }

    static void Test(int[] arr, int k, int expected)
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

    static int MaxSumSubarray(int[] arr, int k)
    {
        int sum = 0;
        int maxSum = 0;

        for (int i = 0; i < k; i++) sum+=arr[i];
        maxSum = sum;

        var shifts = arr.Length - k;

        for (int i=0; i < shifts; i++)
        {
            sum += -arr[i] + arr[i+k];
            maxSum = Math.Max(maxSum,sum);
        }

        return maxSum;
    }
}