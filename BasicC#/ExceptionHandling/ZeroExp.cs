using System;
using System.Collections.Generic;
using System.Text;

namespace BasicC_.ExceptionHandling
{
    internal class ZeroExp : Exception
    {
        public ZeroExp(String msg) : base(msg) { }
    }
}
