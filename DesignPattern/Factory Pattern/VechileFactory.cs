using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Factory_Pattern
{
    internal class VechileFactory
    {
        public static IVechiles GetVehicle(string type)
        {
            if (type == "Car")
                return new Car();
            else if (type == "Bike")
                return new Bike();
            else
                throw new ArgumentException("Invalid vehicle type");
        }
    }
}
