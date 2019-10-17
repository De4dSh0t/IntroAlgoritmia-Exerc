using System;

namespace _Keep_randomizing
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            int n = r.Next(1,10);
            
            Console.WriteLine("");
            Console.WriteLine("The player moved " + n + " times!");
            Console.WriteLine("");
            Console.WriteLine("Positions:");
            for(int i = 0; i < n; i++)
            {
                int pX = r.Next(1,100);
                int pY = r.Next(1,100);
                Console.WriteLine("(" + pX + ", " + pY + ")");
            }
        }
    }
}
