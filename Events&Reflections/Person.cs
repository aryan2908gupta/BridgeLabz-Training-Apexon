  using System;
using System.Collections.Generic;
using System.Text;

namespace Events_Reflections
{
    internal class Person
    {
        public void WakeUp(object sender, EventArgs e)
        {
            Console.WriteLine("Wake up");
        }
    }
}
