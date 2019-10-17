using System;

namespace _Time_over
{
    class Program
    {
        static void Main(string[] args)
        {
            int time = 99;

            for(int i = 0; i < 99; i++)
            {
                time -= 1;
                Console.WriteLine(time);
            }
            if(time == 0)
            {
                Console.WriteLine("Time Over! Pretty fast hum...");
            }
        }
    }
}
