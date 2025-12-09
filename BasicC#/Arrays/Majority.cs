using System;
using System.Collections.Generic;
using System.Text;

namespace BasicC_.Arrays
{
    internal class Majority
    {
        public void majority()
        {
            int[] arr = { 1, 2, 3, 4, 5, 5, 6, 7, 7, 8, 8, 8, 5, 5, 5 };
            int candinate = 0;
            int cnt = 0;
            foreach (int i in arr)
            {
                if (cnt == 0)
                {
                    candinate = i;
                }

                if (candinate == i)
                {
                    cnt++;
                }
                else
                {
                    cnt--;
                }
            }

            Console.WriteLine(candinate);
        }

    }
}
