using System;
using System.Threading;

namespace Otus.AsyncOperations
{
  internal static class BasicShowcase
  {
    public static void Run()
    {
      ThreadPool.QueueUserWorkItem(SendEmail, "bill.gates@microsoft.com");
      Console.WriteLine("Waiting for completion");
      Thread.Sleep(500);
    }

    private static void SendEmail(object? email)
    {
      // simulate some work
      Thread.Sleep(100);
      Console.WriteLine($"Email sent to {email}");
    }
  }
}