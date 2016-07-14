using System;

namespace KV.AsyncMethods
{
    using System.Threading.Tasks;

    class Program
    {
        static void Main(string[] args)
        {
            new SampleAsyncClass().Foo1();

            Console.WriteLine("After Foo1 " + DateTime.Now.Millisecond);

            Console.ReadKey();
        }
    }

    public class SampleAsyncClass
    {
        public async void Foo1()
        {
            await Task.Yield();

            Console.WriteLine("Foo1 at " + DateTime.Now.Millisecond);
                       
            Console.WriteLine("End of Foo1 at " + DateTime.Now.Millisecond);
        }
    }
}