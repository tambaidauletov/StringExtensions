using System;
using StringExtensions;

class Program
{
    static void Main(string[] args)
    {
        string example = "Hello!";
        bool result = example.StartsWithUpper();

        Console.WriteLine($"Starts with uppercase? {result}");
    }
}
