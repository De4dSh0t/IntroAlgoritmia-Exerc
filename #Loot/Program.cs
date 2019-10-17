using System;

namespace _Loot
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            
            double rare = 0.10;
            double uncommon = 0.30;
            double common = 0.60;
            float chance = r.Next(0.00, 1.00);

        }
    }
}
