using System;
using System.Collections.Generic;
using System.Text;

namespace MultiThreading.Multithreading.cs
{
    internal class multhiread
    {
       public void RunThread()
        {
            
            Thread t1 = new Thread(Method1) { Name = "Thread1"};
            Thread t2 = new Thread(Method2) { Name = "Thread1" };
            Thread t3 = new Thread(Method3) { Name = "Thread1" };

            t1.Start();
            t2.Start();
            t3.Start();

            Console.WriteLine("Main Thread Ended");
        }
        public void Method1()
        {
            Console.WriteLine("Method1 Started using " + Thread.CurrentThread.Name);
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Method1 : " + i);
            }
            Console.WriteLine("Method1 Ended using " + Thread.CurrentThread.Name);
        }

        public void Method2()
        {
            Console.WriteLine("Method2 Started using " + Thread.CurrentThread.Name);
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Method2 : " + i);
                if (i == 3)
                {
                    Console.WriteLine("Performing the Database Operation Started");
                    Thread.Sleep(10000); // 10 seconds
                    Console.WriteLine("Performing the Database Operation Completed");
                }
            }
            Console.WriteLine("Method2 Ended using " + Thread.CurrentThread.Name);
        }

        public void Method3()
        {
            Console.WriteLine("Method3 Started using " + Thread.CurrentThread.Name);
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Method3 : " + i);
            }
            Console.WriteLine("Method3 Ended using " + Thread.CurrentThread.Name);
        }
    }
}
