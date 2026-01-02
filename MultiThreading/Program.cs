using MultiThreading.DeadLock;
using MultiThreading.Multithreading.cs;
using MultiThreading.SingleThread;

namespace MultiThreading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Thread t = Thread.CurrentThread;
            Console.WriteLine(t.Name); // Empty 
            t.Name = "Aryan Thread";
            Console.WriteLine(t.Name); // Aryan Thread
            Console.WriteLine(Thread.CurrentThread.Name); // Aryan Thread

            Console.WriteLine("Processor Count : "+Environment.ProcessorCount);
            

            Console.WriteLine("-----------------------------------------------------------------");
            */
            /*
             singlethread.Method1();
             singlethread.Method2(); // Now because of this method 2 will delay exc of method 3 by 10 sec
             singlethread.Method3();
            */

            /*
            Console.WriteLine("------------------------------------------------------");
            multhiread ts = new multhiread();
            ts.RunThread();
            */

            // DeadLock
            Account acc1 = new Account(1);
            Account acc2 = new Account(2);

            AccountManager m1 = new AccountManager(acc1, acc2);
            AccountManager m2 = new AccountManager(acc2, acc1);

            Thread t1 = new Thread(m1.FundTransfer);
            Thread t2 = new Thread(m2.FundTransfer);

            t1.Start();
            t2.Start();

            t1.Join();
            t2.Join();

        }
    }
}
