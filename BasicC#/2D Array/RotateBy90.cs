using System;
using System.Collections.Generic;
using System.Text;

namespace BasicC_._2D_Array
{
    internal class RotateBy90
    {
        public void rotate()
        {
            int[,] mat = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            Console.WriteLine("Rotating Array by 90 : ");

            for (int i=0; i < 3;i++)
            {
                for(int j=i; j < 3; j++)
                {
                    int temp = mat[i,j];
                    mat[i,j] = mat[j,i];
                    mat[j,i] = temp;
                }
            }

            for(int i=0; i < 3; i++)
            {
                int left = 0;
                int right = 2;
                while (left < right)
                {
                    int temp = mat[i,left];
                    mat[i,left] = mat[i,right];
                    mat[i,right] = temp;
                    left++;
                    right--;
                }
            }
            Console.WriteLine("Array Rotated By 90 : ");
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    Console.Write(mat[i,j]+" ");
                }
                Console.WriteLine();
            }
            
        }
    }
}
