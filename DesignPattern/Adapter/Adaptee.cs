using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Adapter
{
    internal class Adaptee
    {
        public void SpecificRequest()
        {
            Console.WriteLine("Specific request from Adaptee");
        }
    }
}
