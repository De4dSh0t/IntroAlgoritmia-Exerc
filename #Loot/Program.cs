using System;

namespace _Loot
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            
            string r1;

            for(int i = 0; i < 2; i++)
            {
                int roll = r.Next(0,101);

                if(roll <= 10)
                {
                    r1 = "a RARE";
                    Console.WriteLine("You got " + r1 + " item!");
                }
                else if(roll > 10 && roll < 40)
                {
                    r1 = "an UNCOMMON";
                    Console.WriteLine("You got " + r1 + " item!");
                }
                else if(roll > 40)
                {
                    r1 = "a COMMON";
                    Console.WriteLine("You got " + r1 + " item!");
                }
            }
        }
    }
}
