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
    }

    static void Test(int[] input)
    {
        int[] copy = new int[input.Length];
        Array.Copy(input, copy, input.Length);

        QuickSort(copy, 0, copy.Length - 1);

        Console.WriteLine($"Input : [{string.Join(",", input)}]");
        Console.WriteLine($"Sorted: [{string.Join(",", copy)}]");
        Console.WriteLine();
    }

    static void QuickSort(int[] arr, int left, int right)
    {
    }
}