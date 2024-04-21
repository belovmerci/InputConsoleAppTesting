using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputConsoleAppTesting
{
    public static class MatrixMultiplier
    {
        public static int[,] GenerateMultiplicationMatrix(int x, int y)
        {
            int[,] matrix = new int[x, y];

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    matrix[i, j] = (i + 1) * (j + 1);
                }
            }

            return matrix;
        }
    }
}
