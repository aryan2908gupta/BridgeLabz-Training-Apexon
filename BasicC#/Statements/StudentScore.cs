using System;
using System.Collections.Generic;
using System.Text;

namespace BasicC_.Statements
{
    internal class StudentScore

    {
        public void grade() {
            Console.Write("Enter your marks : ");
            int marks = int.Parse(Console.ReadLine());
            

            if (marks>=90 && marks <=100)
            {
                Console.WriteLine('A');
            }

            else if (marks >= 80 && marks <= 89)
            {
                Console.WriteLine('B');
            }

            else if (marks >= 70 && marks <= 79)
            {
                Console.WriteLine('C');
            }

           else if (marks >= 60 && marks <= 69)
            {
                Console.WriteLine('D');
            }

            else
            {
                Console.WriteLine('F');
            }
        }
    }
}
