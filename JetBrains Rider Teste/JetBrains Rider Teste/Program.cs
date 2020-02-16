using System;

namespace JetBrains_Rider_Teste
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = 4;
            int cols = 6;
            int[,] matrix = new int[rows, cols];
            Fill(matrix, rows, cols);
            PrintMatrix(matrix, rows, cols);
        }

        static void Fill(int[,] matrix, int rows, int cols)
        {
            Random r = new Random();
            for (int y = 0; y < rows; y++)
            {
                for (int x = 0; x < cols; x++)
                {
                    matrix[y, x] = r.Next(100);
                }
            }
        }

        static void PrintMatrix(int[,] matrix, int rows, int cols)
        {
            for (int y = 0; y < rows; y++)
            {
                for (int x = 0; x < cols; x++)
                {
                    Console.WriteLine(matrix[y,x]);
                }
                Console.WriteLine("\n");
            }
        }
    }
}