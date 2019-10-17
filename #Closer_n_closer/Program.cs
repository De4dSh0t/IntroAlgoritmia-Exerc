using System;

namespace _Closer_n_closer
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            int p1, p2, p3; //Player1, Player2 e Player3
            int distP1P2, distP1P3, distP2P3; //Distâncias

            p1 = r.Next(0,501); //Posição do Player1
            p2 = r.Next(0,501); //Posição do Player2
            p3 = r.Next(0,501); //Posição do Player3

            //Fazer com que o número maior seja sempre o primeiro ao subtrair, de forma a evitar numeros negativos.
            if(p1 > p2)
            {
                distP1P2 = p1 - p2;
            }
            else
            {
                distP1P2 = p2 - p1;
            }
            if(p1 > p3)
            {
                distP1P3 = p1 - p3;
            }
            else
            {
                distP1P3 = p3 - p1;
            }
            if(p2 > p3)
            {
                distP2P3 = p2 - p3;
            }
            else
            {
                distP2P3 = p3 - p2;
            }

            //Ver quem está mais perto de quem...
            if(distP1P2 < distP2P3)
            {
                Console.WriteLine("Player 1 is closer to Player 2.");
            }
            else
            {
                Console.WriteLine("Player 3 is closer to Player 2.");
            }
            if(distP1P3 < distP2P3)
            {
                Console.WriteLine("Player 1 is closer to Player 3.");
            }
        }
    }
}
