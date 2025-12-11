using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.Constructor
{
    internal class StaticConstructor
    {
        static int x;
        int y;
         static StaticConstructor()
        {
            x = 10;
            // Will throw an error because static cant acces non static members and vice versa 
            //y = 45;
            Console.WriteLine($"x is {x} ");
            Console.WriteLine("Inside a Static Constructor");
        }

        // Non Static Constructor
        public StaticConstructor()
        {
            // Non static can access both static and non static variable
             x = 90;
            y = 23;
            Console.WriteLine($"x is {x} and y is {y}");
            Console.WriteLine("Inside a non Static Constructor");
        }
    }
}
