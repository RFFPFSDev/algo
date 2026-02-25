class Program
{
    static void Main(string[] args)
    {
        RunTests();
    }

    static void RunTests()
    {
        Test(0, 0);
        Test(1, 1);
        Test(2, 1);
        Test(3, 2);
        Test(4, 3);
        Test(5, 5);
        Test(6, 8);
        Test(7, 13);
        Test(8, 21);
        Test(9, 34);
        Test(10, 55);
        Test(15, 610);
        Test(20, 6765);
    }

    static void Test(int n, int expected)
    {
        var result = Fibonacci(n);

        if (result == expected)
        {
            Console.WriteLine($"✅: Fibonacci({n}) -> {result}");
        }
        else
        {
            Console.WriteLine($"❌: Fibonacci({n}) | Expected: {expected}, Got: {result}");
        }
    }

    static int Fibonacci(int n)
    {
        if (n <= 1)
        {
            return n;
        }

        var previousResult = new int[2];
        previousResult[0] = 0;
        previousResult[1] = 1;

        for (int i=2; i <= n; i++)
        {
            int temp = previousResult[1] + previousResult[0];
            previousResult[0] = previousResult[1];
            previousResult[1] = temp;
        }

        return previousResult[1];
    }
}