using System;
using System.Threading;

namespace Otus.AsyncOperations
{
  public static class ThreadCountShowase
  {
    public static void Run()
    {
      ThreadPool.GetMinThreads(out var minWorkerThreads, out var minCompletionPortThreads);
      ThreadPool.GetMaxThreads(out var maxWorkerThreads, out var maxCompletionPortThreads);

      Console.WriteLine($"Min CPU threads: {minWorkerThreads}, Min IO threads: {minCompletionPortThreads}");
      Console.WriteLine($"Max CPU threads: {maxWorkerThreads}, Max IO threads: {maxCompletionPortThreads}");
      Console.WriteLine();

      Console.WriteLine($"Currently allocated: {ThreadPool.ThreadCount}");

      for (var i = 0; i < 10; i++)
      {
        ThreadPool.QueueUserWorkItem(SimulateWork, null);
        Thread.Sleep(100);
      }

      Console.WriteLine($"Allocated after spawning some work: {ThreadPool.ThreadCount}");

      Thread.Sleep(2000);
    }

    private static void SimulateWork(object? state)
    {
      Thread.Sleep(1000);
    }
  }
}