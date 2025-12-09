using BasicC_.Statements;
using System;
using System.Collections.Generic;
using System.Text;

namespace BasicC_.Strings
{
    internal class Reversee
    {
        public string rever(string s)
        {
            char[] chars = s.ToCharArray();
           // String ans = "";
            int i = 0;
            int j = s.Length - 1;
            while (i <= j)
            {
                char temp = chars[i];
                chars[i] = chars[j];
                chars[j] = temp ;
                i++;
                j--;
            }
            return new string(chars);

        }

        public bool checkPalindrome(string s,string ans) 
        {
            if (s == ans)
            {
                return true;
            }
            return false;
        }
        public void rev()
        {
            string s = "aryan";
         string ans =    rever(s);
            Console.WriteLine($"Reversed String is : {ans}");
            Console.WriteLine();
            if(checkPalindrome(s,ans))
            {
                Console.WriteLine("Pallindrome");
            }
            else
            {
                Console.WriteLine("Not a Pallindrome");
            }

        }
    }
}
