using System;

namespace _Checkers
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = 8;
            int columns = 8;
            string[,] board = new string[rows,columns];

            BoardFill(board, rows, columns);
            PrintMatrix(BoardFill(board, rows, columns));
        }

        static string[,] BoardFill(string[,] board, int rows, int columns)
        {
            int b = 1;
            
            for(int y = 0; y < rows; y++)
            {
                int a = 0;
                a += b;

                for(int x = 0; x < columns; x++)
                {
                    if(a % 2 != 0) //Se "a" for ímpar
                    {
                        board[y, x] = "W"; //White
                    }
                    else //Se "a" for par
                    {
                        board[y, x] = "B"; //Black
                        if(b < 4) board[y,x] = "WhiteC";
                        else if(b > 5) board[y,x] = "BlackC";
                    }
                    a++;
                }
                b++;
            }

            return board;
        }

        static void PrintMatrix(string[,] m)
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
