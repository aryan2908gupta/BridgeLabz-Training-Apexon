using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Adapter
{
    internal class Adapter : ITarget
    {
        private readonly Adaptee adaptee;

        public Adapter(Adaptee adaptee)
        {
            this.adaptee = adaptee;
        }

        public void Request()
        {
            // translating call
            adaptee.SpecificRequest();
        }
    }
}
