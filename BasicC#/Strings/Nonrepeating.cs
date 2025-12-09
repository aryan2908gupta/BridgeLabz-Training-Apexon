using System;
using System.Collections.Generic;
using System.Text;

namespace BasicC_.Strings
{
    internal class Nonrepeating
    {
        public void nonrepeat()
        {
            String s = "aabcddeffasx";
            Dictionary<char, int> st = new Dictionary<char, int>();
            foreach (char ch in s)
            {
                if (st.ContainsKey(ch))
                {
                    st[ch]++;
                }
                else
                {
                    st[ch] = 1;
                }

            }

            foreach(char ch in s)
            {
                if (st[ch] == 1)
                {
                    Console.WriteLine(ch);
                    break;
                }
               
            }

        }
    }
}