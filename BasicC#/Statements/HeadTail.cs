using System;
using System.Collections.Generic;
using System.Text;

namespace BasicC_.Statements
{
    internal class HeadTail
    {
        public void getTail()
        {
            Random random = new Random();
            double num = random.NextDouble();

            if (num < 0.5)
            {
                Console.WriteLine("Tails");
            }
            else
            {
                Console.WriteLine("Heads");
            }

            Console.WriteLine("End");

        }
    }
}
