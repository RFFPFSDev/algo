using System.Text;

class Program
{
    static void Main()
    {
        var sb = new StringBuilder("Hello");
        sb[0] = 'B';        // ✅ Allowed
        char firstLetter = sb[0];
        sb.Append(" World");

        string result = sb.ToString();

        Console.WriteLine(result);
        Console.WriteLine(firstLetter);
    }
}