using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.Abstraction
{
    internal interface Interface1
    {
        public void sound();
    }

    class Cat : Interface1 { 
        public void sound()
        {
            Console.WriteLine("Cat is making sound");
        }
    }
}
