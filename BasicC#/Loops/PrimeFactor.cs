using System;
using System.Collections.Generic;
using System.Text;

namespace BasicC_.Loops
{
    internal class PrimeFactor
    {
        public void Prime()
        {
            Console.Write("Enter the number : ");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine();

            for(int i = 2; i <= x; i++)
            {
                while (x % i == 0 && x > 0)
                {
                    Console.WriteLine(i);
                    x = x / i;
                }
            }
        }
    }
}
