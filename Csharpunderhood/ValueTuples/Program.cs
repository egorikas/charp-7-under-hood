using System;

namespace ValueTuples
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = GetPersonalInfo();
            Console.WriteLine($"Имя - {data.Item1}, возраст - {data.Item2}");

            var namedData = GetPersonalInfoNamed();
            Console.WriteLine($"Имя - {namedData.name}, возраст - {namedData.age}");

            var (name, age) = GetPersonalInfo();
        }

        public static (string, int) GetPersonalInfo()
        {
            return ("Алиса", 123);
        }

        public static (string name, int age) GetPersonalInfoNamed()
        {
            return ("Алиса", 123);
        }
    }
}
