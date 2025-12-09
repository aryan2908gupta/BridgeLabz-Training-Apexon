using System;
using System.Collections.Generic;
using System.Text;

namespace BasicC_._2D_Array
{
    internal class Transposeofmatrix
    {
        public void transpose()
        {
            int[,] mat = { { 1, 2, 3 }, { 4, 5, 6 } };
            int row = mat.GetLength(0);  // Number of rows
            int cols = mat.GetLength(1);

            int[,] res = new int[cols,row];
            for(int i = 0; i < row; i++)
            {
                for(int j = 0; j < cols; j++)
                {
                    res[j,i] = mat[i, j];
                }
            }
            Console.WriteLine("Transpose of matrix : ");
            for(int i=0; i < cols; i++)
            {
                for(int j = 0; j < row; j++)
                {
                    Console.Write(res[i,j]+" ");
                }
                Console.WriteLine();
            }

        }
    }
}
