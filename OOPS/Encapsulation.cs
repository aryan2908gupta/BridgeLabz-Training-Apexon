using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS
{
    internal class Encapsulation
    {
        private string name; 
        public string getName()
        {
            return this.name;
        }

        public void setName(string name)
        {
            this.name = name;
        }
    }
}
