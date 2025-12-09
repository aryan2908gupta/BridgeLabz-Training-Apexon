using System;
using System.Collections.Generic;
using System.Text;

namespace BasicC_.Arrays
{
    internal class MissingNumber
    {
        public void missNumber()
        {
            int[] arr = { 1, 2, 4, 5, 6, 7, 8, 9};
            int sum = 0;
            int n = arr.Length;
            n = n + 1;
            int sumofN = (n * (n + 1)) / 2;
            foreach(int i in arr)
            {
                sum+= i;
            }

            int ans = Math.Abs(sum - sumofN);
            Console.WriteLine(ans);
        }
    }
}
