using System;
using System.Collections.Generic;
using System.Text;

namespace BasicC_.Loops
{
    internal class Swap

    {
        public void swap()
        {
            int a = 12;
            int b = 13;
            Console.WriteLine($"a={a} b={b}");
            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine($"a={a} b={b}");

        }
    }
}
