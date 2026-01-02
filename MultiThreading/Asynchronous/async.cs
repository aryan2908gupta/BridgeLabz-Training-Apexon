using System;
using System.Collections.Generic;
using System.Text;

namespace MultiThreading.Asynchronous
{
    internal class async
    {
        static void Run()
        {
            Console.WriteLine("Main Method Started...");
            SomeMethod();
            Console.WriteLine("Main Method End");
            Console.ReadKey();
        }

        public async static void SomeMethod()
        {
            Console.WriteLine("Some Method Started...");
            SomeMethod2();
            await Task.Delay(10000); // Non-blocking
            Console.WriteLine("Some Method End");
        }
        public async static Task SomeMethod2()
        {
            Console.WriteLine("Some Method2 Started...");
            await Task.Delay(10000); // Non-blocking
            Console.WriteLine("Some Method2 End");
        }
    }
}
