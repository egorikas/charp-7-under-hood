using System;

namespace ReadonlyStruct
{
    public readonly struct Information
    {
        public int Age { get; }
        public readonly int Age2;

        public Information(int age)
        {
            this.Age = age;
            this.Age2 = age;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var info = new Information(12);
            Console.WriteLine(info.ToString());
        }
    }
}
