using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.Inheritance
{
    internal class Singleinheritance
    {
        public void display()
        {
            Console.WriteLine("Inside a parent class");
        }
    }

    internal class  Child : Singleinheritance
    {
        public void displayMsg()
        {
            Console.WriteLine("Inside a child class");
        }
    }
}
