using System;
using System.Threading;
using System.Threading.Tasks;

namespace Otus.AsyncOperations
{
  public class AsyncLocalShowcase
  {
    public static async Task Run()
    {
      var user = new AsyncLocal<string>
      {
        Value = "initial user"
      };

      var task1 = Task.Run(async () =>
      {
        
        Console.WriteLine(user.Value); // выведет "initial user"
        user.Value = "user from task1";

        await Task.Run(() =>
        {
          // выведет "initial user"
          // изменение из родительской таски перетекло в дочернюю
          Console.WriteLine(user.Value);
        });
      });

      await task1;

      // выведет "initial user"
      // изменения из дочерней таски не влияют на родительскую
      Console.WriteLine(user.Value);
    }
  }
}