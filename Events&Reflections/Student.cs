using System;
using System.Collections.Generic;
using System.Text;

namespace Events_Reflections
{
    internal class Student
    {
        public void OnResultDeclared(object sender, ResultEventArgs e)
        {
            Console.WriteLine($"Student received marks: {e.Marks}");
        }
    }
}
