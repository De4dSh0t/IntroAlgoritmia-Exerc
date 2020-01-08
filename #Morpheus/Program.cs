using System;

namespace _Morpheus
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = 4;
            int cols = 6;

            int[,] A = new int[rows, cols];
            int[,] B = new int[rows, cols];

            Fill(A, B, rows, cols);
            SMatrix(A, B, rows, cols);
            DMatrix(A, B, rows, cols);
            PrintMatrix(SMatrix(A, B, rows, cols));
        }

        static void Fill(int[,] A, int[,] B, int rows, int cols)
        {
            Random r = new Random();

            for(int y = 0; y < rows; y++)
            {
                for(int x = 0; x < cols; x++)
                {
                    A[y, x] = r.Next(100);
                    B[y, x] = r.Next(100);
                }
            }
        }

        static int[,] SMatrix(int[,] A, int[,] B, int rows, int cols)
        {
            int[,] m = new int[rows,cols];

            for(int y = 0; y < rows; y++)
            {
                for(int x = 0; x < cols; x++)
                {
                    m[y,x] = A[y,x] + B[y,x];
                }
            }

            return m;
        }

        static int[,] DMatrix(int[,] A, int[,] B, int rows, int cols)
        {
            int[,] m = new int[rows, cols];

            for(int y = 0; y < rows; y++)
            {
                for(int x = 0; x < cols; x++)
                {
                    m[y, x] = A[y,x] - B[y,x];
                }
            }

            return m;
        }

        static void PrintMatrix(int[,] m)
        {
            for (int row = 0; row < m.GetLength(0); row++)
            {
                for (int col = 0; col < m.GetLength(1); col++)
                {

                    Console.Write(m[row, col]);
                    Console.Write("\t");
                }
                Console.Write("\n");
            }
        }
    }
}
