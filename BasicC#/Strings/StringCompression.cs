using System;
using System.Collections.Generic;
using System.Text;

namespace BasicC_.Strings
{
    internal class StringCompression
    {
        public void stringcomp()
        {
            String s = "aaabcddee";
            Dictionary<char,int> st = new Dictionary<char,int>();
            foreach(char c in s)
            {
                if (!st.ContainsKey(c))
                {
                    st[c] = 1;
                }
                else
                {
                    st[c]++;
                }
            }
            foreach(var item in st)
            {
                Console.WriteLine($"{item.Key}{item.Value}");
            }
        } 
    }
}
