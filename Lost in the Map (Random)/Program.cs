using System;

namespace Lost_in_the_Map__Random_
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            int x, y;
            string l, r1, t, b;

            x = r.Next(0,500);
            y = r.Next(0,500);

            //Posição X
            if(x < 250)
            {
                l = " left";
                r1 = "";
            }
            else
            {
                r1 = " right";
                l = "";
            }
            
            //Posição Y
            if(y < 250)
            {
                t = " top";
                b = "";
            }
            else
            {
                b = " bottom";
                t = "";
            }

            Console.WriteLine("The Player is located at" + t + b + l + r1 + "!");
        }
    }
}
