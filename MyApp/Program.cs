class Program
{
    static void Main()
    {  
        Console.WriteLine($"17 % 5 = {17 % 5}");
        Console.WriteLine($"8 is even? {8 % 2 == 0}");
        Console.WriteLine($"9 is odd? {9 % 2 != 0}");
        double division = 5.0 / 2.0;
        Console.WriteLine($"5.0 / 2.0 = {division}");
        Console.WriteLine($"(int)2.5: {(int)division}");
        double division2 = 5 / 2;
        Console.WriteLine($"5 / 2 = {division2}");
        double division3 = ((double)5) / 2;
        Console.WriteLine($"((double)5) / 2 = {division3}");
        Console.WriteLine($"Math.Min(10, 25) = {Math.Min(10, 25)}");
        Console.WriteLine($"Math.Max(10, 25) = {Math.Max(10, 25)}");
        Console.WriteLine($"Math.Floor(4.1) = {Math.Floor(4.1)}");
        Console.WriteLine($"Math.Floor(4.9) = {Math.Floor(4.9)}");
        Console.WriteLine($"Math.Ceiling(4.1) = {Math.Ceiling(4.1)}");
        Console.WriteLine($"Math.Ceiling(4.9) = {Math.Ceiling(4.9)}");
        Console.WriteLine($"Math.Round(4.3) = {Math.Round(4.3)}");
        Console.WriteLine($"Math.Round(4.5) = {Math.Round(4.5)}");
        Console.WriteLine($"Math.Round(4.6) = {Math.Round(4.6)}");
    }
}