using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.Multiple_Inheritance
{
    internal class Living
    {
        public void breathe()
        {
            Console.WriteLine("Person  Breathing.....");
        }
    }

    internal class Animal : Living
    {
        public void animalbreathe()
        {
            Console.WriteLine("Animal breathing ");
        }
    }
    internal class Dog : Animal { 
        public void Dogbreathe()
        {
            Console.WriteLine("Dog breathing ");
        }
    }
}
