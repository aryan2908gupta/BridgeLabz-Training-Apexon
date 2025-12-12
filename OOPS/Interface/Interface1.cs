using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.Interface
{
   interface Interface1
    {
        void add(int x, int y);
    }
    interface Interface2 : Interface1
    {
        void sub(int x, int y);
    }

    public class ClassImplementation1 : Interface1 { 
    
        public void add(int x, int y)
        {
            Console.WriteLine($"Sum of x and y is : {x+y}");
        }
    }

    public class ClassImplementation2 : Interface2 {

        public void sub(int x, int y) {
            Console.WriteLine($"Sub of x and y is : {x - y}");
        }

        public void add(int num1, int num2)
        {
            Console.WriteLine($"Sum of {num1} and {num2} is {num1 + num2}");
        }
    }
}
