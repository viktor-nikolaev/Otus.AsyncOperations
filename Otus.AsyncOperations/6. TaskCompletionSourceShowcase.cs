using System;
using System.Threading.Tasks;
using System.Timers;

namespace Otus.AsyncOperations
{
  public static class TaskCompletionSourceShowcase
  {
    public static async Task Run()
    {
      var tcs = new TaskCompletionSource<bool>();

      Console.WriteLine("Starting the timer");

      var timer = new Timer(1000);
      timer.Elapsed += (sender, args) => tcs.SetResult(true);

      await tcs.Task;

      Console.WriteLine("Await is complete");
    }
  }
}