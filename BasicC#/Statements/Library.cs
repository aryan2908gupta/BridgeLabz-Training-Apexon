using System;
using System.Collections.Generic;
using System.Text;

namespace BasicC_.Statements
{
    internal class Library
    {
        public void fine()
        {
            Console.Write("Enter the number of days the book is overdue: ");
            int days = int.Parse(Console.ReadLine());

            double fine = 0;

            if (days <= 7)
            {
                fine = 0;
            }
            else
            {
                fine = (days - 7) * 0.50;
            }

            Console.WriteLine($"The total fine is: ${fine:F2}");
        }
    }
}
