```csharp
  internal class Program
  {
    private static void Main(string[] args)
    {
      int num1 = 0;
      if (num1 == 0)
        Console.WriteLine(string.Format("Maaagic {0}", (object) num1));
      int num2 = 0;
      if (num2 != 0)
        return;
      Console.WriteLine(string.Format("Maaagic #2 {0}", (object) num2));
    }
  }
```