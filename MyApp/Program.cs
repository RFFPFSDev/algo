class Program
{
    static void Main(string[] args)
    {
        RunTests();
    }

    static void RunTests()
    {
        Test(new int[] { 5, 2, 9, 1, 5, 6 });
        Test(new int[] { 3, 7, 8, 5, 2, 1, 9, 5, 4 });
        Test(new int[] { 1 });
        Test(new int[] { });
        Test(new int[] { 10, -1, 2, -10, 5, 0 });
        Test(new int[] { 4, 4, 4, 4 });
        Test(new int[] { 9, 8, 7, 6, 5 });
    }

    static void Test(int[] input)
    {
        int[] copy = new int[input.Length];
        Array.Copy(input, copy, input.Length);

        BubbleSort(copy);

        if (IsSorted(copy))
        {
            Console.WriteLine($"✅: QuickSort([{string.Join(",", input)}]) -> [{string.Join(",", copy)}]");
        }
        else
        {
            Console.WriteLine($"❌: Test Failed");
            Console.WriteLine($"   Input : [{string.Join(",", input)}]");
            Console.WriteLine($"   Output: [{string.Join(",", copy)}]");
        }
    }

    static bool IsSorted(int[] arr)
    {
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] < arr[i - 1])
                return false;
        }
        return true;
    }

    static void BubbleSort(int[] arr)
    {
        int len = arr.Length;
        for (int i=0; i < len; i++)
        {
            bool swapped = false;
            for (int j=1; j < len - i; j++)
            {
                if (arr[j] < arr[j-1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j-1];
                    arr[j-1] = temp;
                    swapped = true;
                }
            }

            if (!swapped)
            {
                break;
            }
        }
    }
}