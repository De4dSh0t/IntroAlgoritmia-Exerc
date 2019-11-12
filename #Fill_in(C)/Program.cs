using System;

namespace _Fill_in_C_
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] score = new int[11];
            int a = 0;
            int b = 1;

            for(int i = 0; i < 11; i++)
            {
                score[i] = a;
                a += b;
                b += 2;
                Console.WriteLine(score[i]);
            }
        }
    }
}
