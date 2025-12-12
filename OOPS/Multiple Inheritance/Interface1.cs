using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.Multiple_Inheritance
{
     interface Interface1
    {
        void Test();
    }

    interface Interface2
    {
        void Test();
    }

    public class ClassImplementation : Interface1, Interface2
    {
        public void Test() {
            Console.WriteLine("Test Method being implemented");
                }
    }
}
