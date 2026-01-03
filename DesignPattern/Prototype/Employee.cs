    using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Prototype
{
    internal class Employee : IEmployeePrototype
    {
        public string Name { get; set; }
        public string Department { get; set; }

        public IEmployeePrototype Clone()
        {
            // Shallow copy
            return (IEmployeePrototype)this.MemberwiseClone();
        }
    }
}

// Concreate Prototype 

//MemberwiseClone() ek shallow copy banata hai jisme value types copy hote hain aur reference types same object ko refer karte hain.