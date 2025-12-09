using System;
using System.Collections.Generic;
using System.Text;

namespace BasicC_.Loops
{
    internal class VowelConstant
    {
        public void vowel()
        {
            char ch = 'A';

            if (ch == 'A' || ch == 'a' ||
    ch == 'E' || ch == 'e' ||
    ch == 'I' || ch == 'i' ||
    ch == 'O' || ch == 'o' ||
    ch == 'U' || ch == 'u')
            {
                Console.WriteLine("It's a vowel.");
            }
            else
            {
                Console.WriteLine("Not a vowel.");
            }


        }
    }
}
