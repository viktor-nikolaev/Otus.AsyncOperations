using System;
using System.Threading;
using System.Threading.Tasks;

namespace Otus.AsyncOperations
{
  public static class AsyncThreadsShowcase
  {
    public static async Task Run()
    {
      Console.WriteLine($"Thread id is {Thread.CurrentThread.ManagedThreadId}");

      await Task.Delay(100);
      Console.WriteLine($"Thread id is {Thread.CurrentThread.ManagedThreadId}");
      
      await Task.Delay(100);
      Console.WriteLine($"Thread id is {Thread.CurrentThread.ManagedThreadId}");
    }
  }
}