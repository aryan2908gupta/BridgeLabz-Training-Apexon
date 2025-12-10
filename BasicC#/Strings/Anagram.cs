using System;
using System.Collections.Generic;
using System.Text;

namespace BasicC_.Strings
{
    internal class Anagram

    {
        public void anag()
        {
            string s1 = "abc";
            string s2 = "bac";

            if (s1.Length != s2.Length)
            {
                Console.WriteLine("Not a Anagram");    
            }
            Dictionary<char,int> st =new Dictionary<char,int>();
            foreach (char c in s1)
            {
                if (st.ContainsKey(c))
                {
                    st[c]++;
                }
                else
                {
                    st[c] = 1; 
                }
            }
            foreach(char c in s2)
            {
                if (!st.ContainsKey(c))
                {
                    Console.WriteLine("Not a Anagram");
                    return;
                }
                st[c]--;
                
            }
        }

    }
}
