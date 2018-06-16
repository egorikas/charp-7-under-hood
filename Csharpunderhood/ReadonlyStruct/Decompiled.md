```csharp
  [IsReadOnly]
  public struct Information
  {
    [CompilerGenerated]
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private readonly int <Age>k__BackingField;
    public readonly int Age2;

    public int Age
    {
      get
      {
        return this.<Age>k__BackingField;
      }
    }

    public Information(int age)
    {
      this.<Age>k__BackingField = age;
      this.Age2 = age;
    }
  }

  internal class Program
  {
    private static void Main(string[] args)
    {
      Console.WriteLine(new Information(12).ToString());
    }
  }
```