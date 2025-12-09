using System;
using System.Collections.Generic;
using System.Text;

namespace BasicC_.Statements
{
    internal class EvenOdd
    {
        public void evenOdd() {

            Console.Write("Enter the number : ");
            int x = int.Parse(Console.ReadLine());

            if (x % 2 == 0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }
        
        }
    }
}
