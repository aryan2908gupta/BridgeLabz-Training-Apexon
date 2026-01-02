using System;
using System.Collections.Generic;
using System.Text;

namespace MultiThreading.SingleThread
{
    public class singlethread
    {
        public static void Method1()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Method1 : " + i);
            }
        }

        public static void Method2() {
           // Thread.Sleep(2000);
            for (int i = 1; i <= 5; i++) {
                Thread.Sleep(1000);
                Console.WriteLine("Method2 : " + i);
            }
        }

        public static void Method3()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Method3 : " + i);
            }
        }

    }

}