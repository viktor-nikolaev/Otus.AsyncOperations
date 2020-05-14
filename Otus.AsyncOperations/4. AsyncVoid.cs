using System;
using System.Threading.Tasks;

namespace Otus.AsyncOperations
{
  public static class AsyncVoidShowcase
  {
    public static async Task Run()
    {
      await AsyncTask();

      await ReturnAsyncTask();

      AsyncVoid();
    }

    private static async void AsyncVoid()
    {
      Console.WriteLine("RunAsyncVoid started");
      await Task.Delay(1000);
      Console.WriteLine("RunAsyncVoid completed");
    }

    private static async Task AsyncTask()
    {
      Console.WriteLine("RunAsyncTask started");
      await Task.Delay(1000);
      Console.WriteLine("RunAsyncTask completed");
    }

    private static Task ReturnAsyncTask()
    {
      Console.WriteLine("RunReturnAsyncTask started");
      return Task.Delay(1000);
    }
  }
}