using System;

namespace _Fill_in_b_
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] score = new int[10];

            for(int i = 0; i < 10; i++)
            {
                score[i] = i + 1;
                score[i+5] = (i + 1) * 10;
            }
        }
    }
}
