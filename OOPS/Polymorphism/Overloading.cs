using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.Polymorphism
{
    internal class Overloading
    {
        public int add(int a, int b)
        {
            return a + b;
        }
        public float add(float a, float b) {

            return a + b; 
        }

        public string add(string a, string b) {
            return a + b;
        }
    }
}
