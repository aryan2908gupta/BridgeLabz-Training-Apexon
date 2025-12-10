using System;
using System.Collections.Generic;
using System.Text;

namespace BasicC_.Strings
{
    internal class RotationString
    {
        public void rotate()
        {
            string s1 = "abcd";
            string s2 = "cdab";
            string s3 = s1 + s1;
            if (s3.Contains(s2))
            {
                Console.WriteLine("Yes it is a rotated String ");
                return;
            }
            else
            {
                Console.WriteLine("Not a Rotated String");

            }
            return;
        }
    }
}
