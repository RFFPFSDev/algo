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
        Test(new int[] { 1, 2 }, 3, -1);                  // k > array length, invalid
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
        if (k > arr.Length || k <= 0)
        {
            return -1;
        }

        if (k == 1)
        {
           return arr.Max();
        }

        int sum = 0;
        for (int i=0; i < k; i++)
        {
            sum+=arr[i];
        }
        int maxSum = sum;

        for (int a = 0; a < arr.Length - k; a++)
        {
            sum+=arr[a + k]-arr[a];
            if (sum > maxSum)
            {
                maxSum = sum;
            }
        }

        return maxSum;
    }
}