using System;
using System.Collections.Generic;
using System.Text;

namespace Events_Reflections
{
    internal class ResultEventArgs : EventArgs
    {
        public int Marks { get; }
        public ResultEventArgs(int marks)
        {
            Marks = marks;
        }
    }
}
