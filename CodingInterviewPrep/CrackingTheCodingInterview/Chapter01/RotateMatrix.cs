using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace CrackingTheCodingInterview
{
    // ML: Will need to review, having trouble wrapping head around the math
    public class RotateMatrix
    {
        public int[,] Rotate(int[,] matrix)
        {
            if(matrix.Length == 0 || matrix.GetLength(0) != matrix.GetLength(1))
            {
                return matrix;
            }

            var n = matrix.GetLength(0);
            for(int layer = 0; layer < n/2; layer++)
            {
                var first = layer;
                var last = n - 1 - layer;
                for(int i = first; i < last; i++)
                {
                    var offset = i - first;
                    var top = matrix[first, i];

                    matrix[first, i] = matrix[last-offset, first];
                    matrix[last-offset, first] = matrix[last, last-offset];
                    matrix[last, last-offset] = matrix[i, last];
                    matrix[i, last] = top;
                }
            }

            return matrix;
        }
    }
}