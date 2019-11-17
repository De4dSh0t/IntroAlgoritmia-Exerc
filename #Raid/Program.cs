using System;

namespace _Raid
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            string[] classes = new string[]{"Priest", "Mage", "Warrior", "Bandit", "Archer", "Necromancer"};
            int[] nClasses = new int[6];

            for(int i = 0; i < 20; i++)
            {
                int a = r.Next(0, 6);
                nClasses[a]++;
            }

            int n = r.Next(0, 6);
            Console.WriteLine(nClasses[n] + " " + classes[n]);
        }
    }
}
