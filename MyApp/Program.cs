using System.Text;

class Program
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder("Hello");
        sb[0] = 'B';        // ✅ Allowed
        sb.Append(" World");

        string result = sb.ToString();

        Console.WriteLine(result);
    }
}