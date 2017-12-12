using System;

namespace KV.AsyncMethods
{
    using System.Threading;
    using System.Threading.Tasks;

    class Program
    {
        static void Main(string[] args)
        {
            new SampleAsyncClass().Foo2Async();

            Console.WriteLine("After Foo1 " + DateTime.Now.Millisecond);

            Console.ReadKey();
        }
    }

    public class SampleAsyncClass
    {
        public async Task Foo2Async()
        {
            Foo1();
            
            Console.WriteLine("Foo3 at " + DateTime.Now.Millisecond);
        }

        public async Task Foo1()
        {
            await Task.Delay(2000);

            Console.WriteLine("Foo1 at " + DateTime.Now.Millisecond);

            Console.WriteLine("End of Foo1 at " + DateTime.Now.Millisecond);
        }
    }
}