using System;
using System.Threading.Tasks;

namespace runner
{
    class Program
    {
        public record Person(string FirstName, string LastName);

        static async Task Main(string[] args)
        {
            //#error version
            Console.WriteLine("Hello World!");
        }
    }
}
