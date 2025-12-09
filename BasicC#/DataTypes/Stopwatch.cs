using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace BasicC_.DataTypes
{
    internal class Stopwatch
    {
    public void  StopwatchTime() {

            Console.WriteLine("Click on enter to start a stopwatch :  ");
            Console.ReadLine();

            DateTime startTime = DateTime.Now;

            Console.WriteLine("Stopwatch started. Press Enter to Stop");

            Console.ReadLine();

            DateTime end = DateTime.Now;

            TimeSpan elapsed = end - startTime;

            Console.WriteLine("Elapsed Time: " + elapsed.TotalSeconds + " seconds");

        }
    }
}
