using System;
using System.Collections.Generic;

namespace CrackingTheCodingInterview
{
    public class ZeroMatrix
    {
        public int[,] Transform(int[,] matrix)
        {
            var columnHasZeros = new bool[matrix.GetLength(0)];
            var rowHasZeros = new bool[matrix.GetLength(1)];
            
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    if(matrix[i,j] == 0)
                    {
                        columnHasZeros[i] = true;
                        rowHasZeros[j] = true;
                    }
                }
            }

            for(int index = 0; index < matrix.GetLength(0); index++)
            {
                if(columnHasZeros[index])
                {
                    for(int i = 0; i < matrix.GetLength(1); i++)
                    {
                        matrix[index, i] = 0;
                    }
                }
                
            }
            
            for(int index = 0; index < matrix.GetLength(1); index++)
            {
                if(rowHasZeros[index])
                {
                    for(int i = 0; i < matrix.GetLength(0); i++)
                    {
                        matrix[i, index] = 0;
                    }
                }
                
            }

            return matrix;
        }
    }
}