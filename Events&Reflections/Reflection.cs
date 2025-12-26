using System;
using System.Collections.Generic;
using System.Text;

namespace Events_Reflections
{
    internal class Reflection
    {
        public void reflcode()
        {
            Type t = typeof(string);
            
            Console.WriteLine("Name : {0}", t.Name);
            Console.WriteLine("Full Name : {0}", t.FullName);
            Console.WriteLine("Namespace : {0}", t.Namespace);
            Console.WriteLine("Base Type : {0}", t.BaseType);
        }
    }
}
