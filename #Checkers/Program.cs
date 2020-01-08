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
                        if(a < 4 && board[y, x] == "W")
                        {
                            board[y,x] = "WhiteChecker";
                        }
                    }
                    else //Se "a" for par
                    {
                        board[y, x] = "B"; //Black
                        if(a > 5 && board[y, x] == "B")
                        {
                            board[y, x] = "BlackChecker";
                        }
                    }
                    a++;
                }

                b++;
            }

            return board;
        }
    }
}
