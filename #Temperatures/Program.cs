using System;

namespace _Temperatures
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            
            int[] temps = new int[100];
            int soma, media;

            for(int i = 0; i < temps.Length; i++)
            {
                temps[i] = r.Next(-30, 51);

                if(temps[i] < 0)
                {
                    Console.WriteLine(temps[i]);
                }
                
                soma += temps[i];
            }

            media = soma / temps.Length;

            Console.WriteLine("The average temperature is " + media);
        }
    }
}
