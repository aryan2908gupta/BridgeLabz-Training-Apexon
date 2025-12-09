using System;
using System.Collections.Generic;
using System.Text;

namespace BasicC_.Statements
{
    internal class Movieticket
    {
        public void getMovie()
        {
            Console.Write("Enter the age : ");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.Write("Enter the movie timings");

            int hrs = int.Parse(Console.ReadLine());

            bool isMatinee = hrs < 17;

            decimal childPrice = 100.3M;
            decimal adult = 150.0M;
            decimal senior = 250.0M;
            decimal discount = 50.0M;

            decimal finalPrice;

            if (age <= 12)
            {
                finalPrice = childPrice;
            }

            else if (age > 12 && age <= 64)
            {
                finalPrice = adult;
            }
            else
            {
                finalPrice = senior;
            }

            if (isMatinee) {
                finalPrice -= discount;
            }

            if (finalPrice < 0)
            {
                finalPrice = 0;
            }
            Console.WriteLine(finalPrice);
        }
    }

}