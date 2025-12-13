using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.Polymorphism
{
    internal class Overriding
    {
        public void show()
        {
            Console.WriteLine("Method not overloaded yet");
        }
    }

    class deriv : Overriding
    {
        public void show()
        {
            Console.WriteLine("Method is being overloaded");
        }
    }
}
