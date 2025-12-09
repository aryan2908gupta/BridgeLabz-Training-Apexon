using System;
using System.Collections.Generic;
using System.Text;

namespace BasicC_.Arrays
{
    internal class Duplicate
    {
        public void dupl()
        {
            int[] arr = { 1, 7, 6, 6, 4, 3, 2 };
            Array.Sort(arr);
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] == arr[i + 1])
                {
                    Console.WriteLine(arr[i]);
                    break;
                }
            }
        }
    }
}