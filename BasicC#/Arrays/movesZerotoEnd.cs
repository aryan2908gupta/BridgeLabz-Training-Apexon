using System;
using System.Collections.Generic;
using System.Text;

namespace BasicC_.Arrays
{
    internal class movesZerotoEnd
    {
        public void moves()
        {
            int []arr = {1,2,0,5,6,3,7,0,0,12,34};
            int zerocnt = 0;
            foreach(int i in arr)
            {
                if (i == 0)
                {
                    zerocnt++;
                }
            }

            int n = arr.Length;
            int cnt = 0;
            for(int i = 0; i < n; i++)
            {
                if (arr[i] != 0)
                {
                    arr[cnt++] = arr[i];
                }
            }

            for(int i = cnt; i < n; i++)
            {
                arr[i] = 0;
            }

            foreach(int i in arr)
            {
                Console.Write($"{i} ");
            }
        }
    }
}
