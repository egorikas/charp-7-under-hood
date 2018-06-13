  internal class Program
  {
    private static Task Main(string[] args)
    {
      Program.<Main>d__0 stateMachine = new Program.<Main>d__0();
      stateMachine.args = args;
      stateMachine.<>t__builder = AsyncTaskMethodBuilder.Create();
      stateMachine.<>1__state = -1;
      stateMachine.<>t__builder.Start<Program.<Main>d__0>(ref stateMachine);
      return stateMachine.<>t__builder.Task;
    }

    [SpecialName]
    private static void <Main>(string[] args)
    {
      Program.Main(args).GetAwaiter().GetResult();
    }

    [CompilerGenerated]
    private sealed class <Main>d__0 : IAsyncStateMachine
			/// State machine
	}
  }