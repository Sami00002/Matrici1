using System;

namespace Matrici_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Dimensiunea matricei :");
            int nr = Int32.Parse(Console.ReadLine());
            int[,] matrix = new int[nr, nr];
            for (int row = 0; row < matrix.GetLength(0); row++)
            { 
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write($"matrix[{row},{col}]:");
                    matrix[row, col] = Int32.Parse(Console.ReadLine());

                }
            }
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {

                    Console.Write(matrix[row, col] + "\t");
                    
                    

                }
                Console.WriteLine();
                        
            }
            if (ArrayHelper.Identitate(matrix) == true)
                Console.WriteLine("Este matrice identitate!");
            else
                Console.WriteLine("Nu este matrice identitate!");
        
        }
    }
}
