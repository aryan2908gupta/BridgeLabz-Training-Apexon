
using System;
using System.Collections.Generic;
using System.Text;

namespace BasicC_.ExceptionHandling
{
    internal class Conditionalexception
    {
       public void error()
        {
            int a = 20;
            int b = 0;

            if (b == 0)
            {
                Console.WriteLine("Cant divide a number by zero");
            }
            else {
                Console.WriteLine("Result : "+a/b);
            }
        }

    }
}
