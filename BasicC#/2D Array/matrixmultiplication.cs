using System;

namespace BasicC_._2D_Array
{
    internal class matrixmultiplication
    {
        public void matrixMult()
        {
            int[,] arr1 = { { 1, 2, 3 }, { 3, 2, 1 } }; // 2x3
            int[,] arr2 = { { 1, 2 }, { 3, 2 }, { 1, 3 } }; // 3x2

            int[,] res = new int[2, 2]; // ✔ 2x2 result
            int sum = 0;

            for (int i = 0; i < 2; i++) // rows of arr1
            {
                for (int j = 0; j < 2; j++) // columns of arr2
                {
                    for (int k = 0; k < 3; k++) // columns of arr1 OR rows of arr2
                    {
                        sum += arr1[i, k] * arr2[k, j];
                    }
                    res[i, j] = sum;
                    sum = 0;
                }
            }

            Console.WriteLine("Result Matrix:");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(res[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
