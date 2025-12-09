 using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace BasicC_.Statements
{
    internal class TrafficLight
    {
        public void light()
        {
            Console.Write("Enter the number of seconds passed: ");
            int t = int.Parse(Console.ReadLine() ?? "0");


            if (t <= 5)
            {
                Console.WriteLine("RED light");
            }
            else if (t <= 10)
            {
                Console.WriteLine("GREEN light");
            }
            else if (t <= 12)
            {
                Console.WriteLine("YELLOW light");
            }
            else
            {
                Console.WriteLine("Light finished");
            }
        }
    }
}
