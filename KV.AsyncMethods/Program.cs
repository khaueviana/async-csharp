using System;

namespace KV.AsyncMethods
{
    using System.Threading;
    using System.Threading.Tasks;

    class Program
    {
        static void Main(string[] args)
        {
            MyClass myclass = new MyClass();

            myclass.Foo1();

            while (MyClass.Count != 3) Thread.Sleep(1);
            foreach (string msg in MyClass.Strings)
            {
                Console.WriteLine(msg);
            }

            Console.ReadKey();
        }
    }

    class MyClass
    {
        public static string[] Strings = new string[3];
        public static int Count = 0;

        public async void Foo1()
        {
            Strings[Count++] = "Foo1 at " + DateTime.Now.Millisecond;

            // Call Foo2 asynchronously AND after this function returns.
            await Foo2();

            Strings[Count++] = "End of Foo1 at " + DateTime.Now.Millisecond;
        }

        private async Task Foo2()
        {
            await Task.Yield();

            Strings[Count++] = "Foo2 called at " + DateTime.Now.Millisecond;
        }
    }
}
