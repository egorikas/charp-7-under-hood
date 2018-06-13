    private static void Main(string[] args)
    {
      ValueTuple<string, int> personalInfo1 = Program.GetPersonalInfo();
      Console.WriteLine(string.Format("Имя - {0}, возраст - {1}", (object) personalInfo1.Item1, (object) personalInfo1.Item2));

      ValueTuple<string, int> personalInfoNamed = Program.GetPersonalInfoNamed();
      Console.WriteLine(string.Format("Имя - {0}, возраст - {1}", (object) personalInfoNamed.Item1, (object) personalInfoNamed.Item2));
     
	 ValueTuple<string, int> personalInfo2 = Program.GetPersonalInfo();
      string str = personalInfo2.Item1;
      int num = personalInfo2.Item2;
    }

    public static ValueTuple<string, int> GetPersonalInfo()
    {
      return new ValueTuple<string, int>("Алиса", 123);
    }

    [return: TupleElementNames(new string[] {"name", "age"})]
    public static ValueTuple<string, int> GetPersonalInfoNamed()
    {
      return new ValueTuple<string, int>("Алиса", 123);
    }