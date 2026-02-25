using System;
using System.Text;

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

    // 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, ..
    static int Fibonacci(int n)
    {
        if (n <= 1)
        {
            return n;
        }

        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }
}