using System;

namespace _I_will_kick_your_ass
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            int select = r.Next(1,3); //Saber quem começa o ataque (Player 1 ou Player 2)
            //bool p1, p2; //Para ter o sitema "Tunn-Based attacks"
            int hp1 = r.Next(100,201); //HP do Player 1
            int hp2 = r.Next(100,201); //HP do Player 2
            int atk1 = r.Next(10,51); //Ataque do Player 1
            int atk2 = r.Next(10,51); //Ataque do Player 2

            //Saber quem ataca primeiro e Turn-Based Attacks (PERDA DE TEMPO!!!!!!!!!!!!!!!!!!!)
            //if(select == 1)
            //{
            //    p1 = true;
            //    if(p1 == true)
            //    {
            //        hp2 -= atk1;
            //        p1 = false;
            //    }
            //    else
            //    {
            //        p2 = true;
            //        if(p2 == true)
            //        {
            //            hp1 -= atk2;
            //            p2 = false;
            //        }
            //        else
            //        {
            //            p1 = true;
            //        }
            //    }
            //}
            //else
            //{
            //    p2 = true;
            //    if(p2 == true)
            //    {
            //        hp1 -= atk2;
            //        p2 = false;
            //    }
            //    else
            //    {
            //        p1 = true;
            //        if(p1 == true)
            //        {
            //            hp2 -= atk1;
            //            p1 = false;
            //        }
            //        else
            //        {
            //            p2 = true;
            //        }
            //    }
            //}

            if(hp1 > hp2 && atk1 > atk2)
            {
                Console.WriteLine("Player 1 Wins!");
            }
            else
            {
                Console.WriteLine("Player 2 Wins!");
            }
        }
    }
}
