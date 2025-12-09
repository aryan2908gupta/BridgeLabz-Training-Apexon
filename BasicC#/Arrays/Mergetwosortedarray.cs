using System;
using System.Collections.Generic;
using System.Text;

namespace BasicC_.Arrays
{
    internal class Mergetwosortedarray
    {
        public void merge()
        {
            int[] arr = { 1, 5, 6 };
            int[] arr2 = { 2, 3, 8 };
            int[] ans = new int[arr.Length+arr2.Length];
            int i = 0;
            int j = 0;
            int cnt = 0;
            while (i < arr.Length && j < arr2.Length)
            {
                if (arr[i] < arr2[j])
                {
                    ans[cnt++] = arr[i];
                    i++;
                }
                else
                {
                    ans[cnt++]= arr2[j];
                    j++;
                }
            }
            while (i < arr.Length)
            {
                ans[cnt++] = arr[i++];
            }

            while (j < arr2.Length)
            {
                ans[cnt++] = arr2[j++];
            }
            foreach (int x in ans)
            {
                Console.Write(x+" ");
            }
    }
    }
}
