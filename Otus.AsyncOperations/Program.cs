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
      // https://sharplab.io/#gist:78177fea60237e719d0deec12bb53c0e

      Console.WriteLine();
      Console.WriteLine("Program is completed");
    }
  }
}