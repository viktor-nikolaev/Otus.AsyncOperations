using System;
using System.Threading;
using System.Threading.Tasks;

namespace Otus.AsyncOperations
{
  public static class AsyncShowcase
  {
    public static void Run()
    {
      Console.WriteLine($"Currently allocated: {ThreadPool.ThreadCount}");

      for (var i = 0; i < 10; i++)
      {
        ThreadPool.QueueUserWorkItem(SimulateWork, null);
        Thread.Sleep(100);
      }

      Console.WriteLine($"Allocated after spawning some work: {ThreadPool.ThreadCount}");

      Thread.Sleep(2000);
    }

    private static async void SimulateWork(object? state)
    {
      await Task.Delay(1000);
    }
  }
}