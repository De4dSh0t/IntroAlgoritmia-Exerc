using System;

namespace _Fill_in_a_
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] score = new int[10];
            int a = 10;

            for(int i = 0; i < 10; i++)
            {
                score[i] = a;
                --a;
                Console.WriteLine(score[i]);
            }
        }
    }
}
