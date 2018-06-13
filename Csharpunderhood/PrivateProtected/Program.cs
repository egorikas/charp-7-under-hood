using System;

namespace PrivateProtected
{
    public class Base
    {
        protected private void M()
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

    class Program
    {
        static void Main(string[] args)
        {
            var d1 = new D1();
            d1.M();
        }
    }
}
