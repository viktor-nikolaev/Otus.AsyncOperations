using System;
using System.Threading.Tasks;

namespace Otus.AsyncOperations
{
  internal class Program
  {
    private static async Task Main(string[] args)
    {
      // BasicShowcase.Run();
      // ThreadCountShowase.Run();
      // AsyncShowcase.Run();
      // await AsyncVoidShowcase.Run();
      // AsyncVoidExceptionShowcase.Run();
      await TaskCompletionSourceShowcase.Run();

      Console.WriteLine();
      Console.WriteLine("Program is completed");
    }
  }
}