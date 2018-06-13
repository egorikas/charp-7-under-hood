using System;

namespace Discard
{
    class Program
    {
        static void Main(string[] args)
        {
            if (bool.TryParse("TRUE", out var parsedValue)) { Console.WriteLine("Parsed"); }
            if (bool.TryParse("TRUE", out bool _)) { Console.WriteLine("Skipped"); }
        }
    }
}
