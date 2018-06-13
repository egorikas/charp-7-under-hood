```csharp
  public class Base
  {
    protected internal void M()
    {
      Console.WriteLine("From Base.M()");
    }
  }

  public class D1 : Base
  {
    public new void M()
    {
      Console.WriteLine("From D1.M()");
      base.M();
    }
  }

  internal class Program
  {
    private static void Main(string[] args)
    {
      new D1().M();
    }
  }

```