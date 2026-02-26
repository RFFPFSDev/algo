using System;

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
        Test(2, 3);
        Test(3, 6);
        Test(4, 10);
        Test(5, 15);
        Test(6, 21);
        Test(7, 28);
        Test(8, 36);
        Test(9, 45);
        Test(10, 55);
        Test(15, 120);
        Test(20, 210);
    }

    static void Test(int n, int expected)
    {
        var result = PrefixSum(n);

        if (result == expected)
        {
            Console.WriteLine($"✅: PrefixSum({n}) -> {result}");
        }
        else
        {
            Console.WriteLine($"❌: PrefixSum({n}) | Expected: {expected}, Got: {result}");
        }
    }

    // 0+1+2+...+n
    // 1 2 3 4 5 6 7 8 9
    static int PrefixSum(int n)
    {
        if (n <= 1)
        {
            return n;
        }

        var middlevalue = n % 2 == 1 ? (n+1)/2 : n/2;
        return n % 2 == 1 ?
            middlevalue + (n+1)*(middlevalue - 1) :
            (n+1)*middlevalue;
    }
}