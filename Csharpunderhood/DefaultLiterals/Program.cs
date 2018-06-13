using System;

namespace DefaultLiterals
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = default;
            if(i == default) Console.WriteLine($"Maaagic {i}");

            int oldDefault = default(int);
            if (oldDefault == default(int)) Console.WriteLine($"Maaagic #2 {oldDefault}");
        }
    }
}
