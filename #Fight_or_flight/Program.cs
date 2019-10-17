using System;

namespace _Fight_or_flight
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            int p1, p2; //Player1 e Player2
            int dist; //Distância

            p1 = r.Next(0,501); //Posição do Player1
            p2 = r.Next(0,501); //Posição do Player2

            dist = p1 - p2; //Distância entre o Player1 e o Player2

            if(dist > -20 && dist < 20)
            {
                Console.WriteLine("Player 2 just flew away!");
            }
            else
            {
                Console.WriteLine("P1 and P2 are " + dist + " pixels away from each other...");
            }
        }
    }
}
