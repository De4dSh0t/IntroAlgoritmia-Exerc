using System;

namespace _Lets_move
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            int pX = 0;
            int pY = 0;
            int targetX = r.Next(1001);
            int targetY = r.Next(1001);

            for(int x = pX; x < targetX; x++)
            {
                pX ++;
            }
            for(int y = pY; y < targetY; y++)
            {
                pY ++;
            }
            Console.WriteLine("Player moved to (" + pX + "," + pY +").");
        }
    }
}
