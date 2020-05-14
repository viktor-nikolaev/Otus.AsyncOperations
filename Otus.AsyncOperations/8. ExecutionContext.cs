using System;
using System.Threading;
using System.Threading.Tasks;

namespace Otus.AsyncOperations
{
  public static class ExecutionContextShowcase
  {
    public static Task Run()
    {
      // see here https://devblogs.microsoft.com/pfxteam/executioncontext-vs-synchronizationcontext/
      var ec = ExecutionContext.Capture();
      ExecutionContext.Run(ec, delegate
      {
        Console.WriteLine("Some work");
      }, null);
      
      return Task.CompletedTask;
    }
  }
}