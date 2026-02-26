class Program
{
    static void Main()
    {  
        Console.WriteLine($"17 % 5 = {17 % 5}");
        Console.WriteLine($"8 is even? {8 % 2 == 0}");
        Console.WriteLine($"9 is odd? {9 % 2 != 0}");
        double division = 5.0 / 2.0;
        int truncated = (int)division;
        Console.WriteLine($"5.0 / 2.0 = {division}");
        Console.WriteLine($"After casting to int: {truncated}");
        double division2 = 5 / 2;
        int truncated2 = (int)division2;
        Console.WriteLine($"5 / 2 = {division2}");
        Console.WriteLine($"After casting to int: {truncated2}");
        double division3 = ((double)5) / 2;
        int truncated3 = (int)division3;
        Console.WriteLine($"((double)5) / 2 = {division3}");
        Console.WriteLine($"After casting to int: {division3}");
        int x = 10;
        int y = 25;
        Console.WriteLine($"X,Y={x},{y}");
        Console.WriteLine($"Min: {Math.Min(x, y)}");
        Console.WriteLine($"Max: {Math.Max(x, y)}");
        Console.WriteLine($"Floor(4.1) = {Math.Floor(4.1)}");
        Console.WriteLine($"Floor(4.9) = {Math.Floor(4.9)}");
        Console.WriteLine($"Ceiling(4.1) = {Math.Ceiling(4.1)}");
        Console.WriteLine($"Ceiling(4.9) = {Math.Ceiling(4.9)}");
        Console.WriteLine($"Round(4.3) = {Math.Round(4.3)}");
        Console.WriteLine($"Round(4.5) = {Math.Round(4.5)}");
        Console.WriteLine($"Round(4.6) = {Math.Round(4.6)}");
    }
}