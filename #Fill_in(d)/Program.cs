using System;

namespace _Fill_in_d_
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] score = new int[11];
            int n = 0;
            int a = 0;
            int b = 1;

            for(int i = 0; i < 11; i++)
            {
                score[i] = n;
                n = a + b;
                a = b;
                b = n;
                Console.WriteLine(score[i]);
            }
        }
    }
}
