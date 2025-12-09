using System;
using System.Collections.Generic;
using System.Text;

namespace BasicC_.Statements
{
    internal class Calculator
    {
        public void Cal()
        {
            Console.Write("Enter the number1 : ");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.Write("Enter the number2 : ");
            int n2 = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.Write("Write the operation to be performed : ");
            char op = Console.ReadLine()[0];

            if (op == '+')
            {
                Console.WriteLine("n1 + n2 = "+(n1 + n2));
            }

            else if (op == '-')
            {
                Console.WriteLine("n1 - n2 = " + (n1 - n2));
            }

            else if (op == '/')
            {
                Console.WriteLine("n1 / n2 = " + (n1 / n2));
            }

            else
            {
                Console.WriteLine("n1 * n2 = "+(n1*n2));
            }

        }
    }
}
