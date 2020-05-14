using System;

namespace Otus.AsyncOperations
{
  public class AsyncVoidExceptionShowcase
  {
    public static void Run()
    {
      try
      {
        ThrowException();
      }
      catch (Exception e)
      {
        Console.WriteLine("Exception caught");
      }

      Console.WriteLine("Finished successfully");
    }

    public static async void ThrowException()
    {
      throw new Exception("Exception in ThrowException");
    }
  }
}