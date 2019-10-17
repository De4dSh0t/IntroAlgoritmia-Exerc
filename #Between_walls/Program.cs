
using System;

namespace _Between_walls
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            int n1 = r.Next(1,100);
            int n2 = r.Next(1,100);
            int max = n1;
            int min = n2;

            if(n2 > n1)
            {
                max = n2;
                min = n1;
            }
            
            for(int i = min; i < max; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
