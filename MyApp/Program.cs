using System.Text;

class Program
{
    static void Main(string[] args)
    {
        RunTests();
    }

    static void RunTests()
    {
        TestStaircase(0);
        TestStaircase(1);
        TestStaircase(2);
        TestStaircase(4);
        TestStaircase(6);
        TestStaircase(10);
    }

    static void TestStaircase(int n)
    {
        Console.WriteLine($"\nStaircase n={n}");
        staircase(n);
    }

    public static void staircase(int n)
    {
        if (n <= 0)
        {
            return;
        }

        var text = new StringBuilder();

        // initialize with spaces
        for (int i = 0; i < n; i++)
        {
            text.Append(' ');
        }

        for (int i = n - 1; i >= 0; i--)
        {
            text[i] = '#';
            Console.WriteLine(text.ToString());
        }
    }
}