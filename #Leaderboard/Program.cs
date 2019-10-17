using System;

namespace _Leaderboard
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            int p1 = r.Next(1,10);
            int p2 = r.Next(1,10);
            int p3 = r.Next(1,10);

            if(p1 == p2 || p1 == p3)
            {
                p1 = r.Next(1,10);
            }
            if(p2 == p3)
            {
                p2 = r.Next(1,10);
            }

            Console.WriteLine("::::::::::LeaderBoard::::::::::");
            Console.WriteLine("          Player 1: " + p1);
            Console.WriteLine("          Player 2: " + p2);
            Console.WriteLine("          Player 3: " + p3);
            Console.WriteLine(":::::::::::::::::::::::::::::::");
        }
    }
}
