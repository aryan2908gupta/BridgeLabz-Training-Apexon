using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.Constructor
{
    internal class CopyConstructor
    {
        int x;

        public CopyConstructor(int i)
        {
            x = i;
        }

        public CopyConstructor(CopyConstructor obj)
        {
            x = obj.x;
        }

        public void display()
        {
            Console.WriteLine($"Value of X is  {x}");
        }
    }
}
