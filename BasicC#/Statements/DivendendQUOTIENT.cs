using System;
using System.Collections.Generic;
using System.Text;

namespace BasicC_.Statements
{
    internal class DivendendQUOTIENT
    {
        public void Qr()

        {
            Console.Write("Enter dividend");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Enter divisor");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine();
            int quotient = n / y;
            int rem = n % y;
            Console.WriteLine($"Quotient is {quotient} and Remainder is {rem}");
        }
    }
}
