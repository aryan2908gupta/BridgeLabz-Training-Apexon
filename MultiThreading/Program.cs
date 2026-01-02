using MultiThreading.Multithreading.cs;
using MultiThreading.SingleThread;

namespace MultiThreading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread t = Thread.CurrentThread;
            Console.WriteLine(t.Name); // Empty 
            t.Name = "Aryan Thread";
            Console.WriteLine(t.Name); // Aryan Thread
            Console.WriteLine(Thread.CurrentThread.Name); // Aryan Thread

            Console.WriteLine("-----------------------------------------------------------------");
           /*
            singlethread.Method1();
            singlethread.Method2(); // Now because of this method 2 will delay exc of method 3 by 10 sec
            singlethread.Method3();
           */
            Console.WriteLine("------------------------------------------------------");
            multhiread ts = new multhiread();
            ts.RunThread();
        }
    }
}
