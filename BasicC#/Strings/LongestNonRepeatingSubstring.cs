using System;
using System.Collections.Generic;
using System.Text;

namespace BasicC_.Strings
{
    internal class LongestNonRepeatingSubstring
    {
        public void nonrepeating()
        {
            string s = "abcabcbb";
            HashSet<char> st = new HashSet<char>();

            int right = 0;
            int left = 0;
            int max = 0;
            int len = s.Length;
            while (right < len)
            {
                if (!st.Contains(s[right]))
                {
                    st.Add(s[right]);
                    right++;
                    max = Math.Max(max, st.Count);

                }
                else
                {
                    st.Remove(s[right]);
                    left++;
                }

            }
            Console.WriteLine(max);
        }
    }
}
