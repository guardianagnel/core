using System;
using System.Threading.Tasks;

namespace HelloWorldSample
{
    public static class Program
    {
        public static async Task Main()
        {ֿ
            var x = "mongodb+srv://gurdian-db:eYRGu3MOgdcb3F26@gurdian-com-g4rrm.mongodb.net/gurdian?retryWrites=true&w=majority"
            await Task.Run(() => Console.WriteLine("Hello World!"));
        }
    }
}
