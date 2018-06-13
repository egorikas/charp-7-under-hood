```csharp
  internal class Program
  {
    private static void Main(string[] args)
    {
      bool result1;
      if (bool.TryParse("TRUE", out result1))
        Console.WriteLine("Parsed");
      bool result2;
      if (!bool.TryParse("TRUE", out result2))
        return;
      Console.WriteLine("Skipped");
    }
  }
```