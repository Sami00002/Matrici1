using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrici_1
{
    class ArrayHelper
    {
        public static bool Identitate(int[,] matrix)
        {
            bool esteIdentitate = true;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {

                    if (row != col)
                    {
                        if (matrix[row, col] != 0)
                        {
                            esteIdentitate = false;
                        }
                    }
                    else if (matrix[row, col] != 1)
                    {
                        esteIdentitate = false;
                    }
                }
            }
            if (esteIdentitate == true)
                return true;
            else
                return false;
        }
    }
}
