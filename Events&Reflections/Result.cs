using System;
using System.Collections.Generic;
using System.Text;

namespace Events_Reflections
{
    internal class Result
    {
        public event EventHandler<ResultEventArgs> ResultDeclared;
        public void Declare(int marks)
        {
            Console.WriteLine("Result declared!");

            ResultDeclared?.Invoke(this, new ResultEventArgs(marks));
        }
    }
}
