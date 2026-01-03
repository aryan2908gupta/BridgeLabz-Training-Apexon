using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Factory_Pattern
{
    internal class Car : IVechiles
    {
        public void Drive()
        {
            Console.WriteLine("Car is Driving");
        }
    }

    internal class Bike : IVechiles
    {

        public void Drive()
        {
            Console.WriteLine("Bike is riding....");
        }
    }
}
// Concreate Product
