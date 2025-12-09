using System;
using System.Collections.Generic;
using System.Text;

namespace BasicC_.Loops
{
    internal class Reverse
    {
        public void reverse()
        {
            int x = 123;
            int sum = 0;
            while (x > 0)
            {
                int rem = x % 10;   
                sum =sum*10+rem;
                x = x / 10;

            }
            Console.WriteLine(sum);
        }
    }
}
