using System;

namespace _Grinder
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            int bank = r.Next(1000,100000); //Quantidade de Ouro, entre 1 000 e 100 000.
            int drop = r.Next(35,65); //Quantidade de Ouro que uma criatura pode dropar.
            int killed = bank / drop; //Calcular o nº de criaturas mortas, consoante o Ouro guardado no Bank.

            if(killed > 1000)
            {
                Console.WriteLine("");
                Console.WriteLine(":::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::");
                Console.WriteLine("::::::::::::::::::::::::::::::::ACHIEVEMENT::::::::::::::::::::::::::::::::");
                Console.WriteLine(":::::                                                                ::::::");
                Console.WriteLine("::::: You achieved the 'Grinder' tier! You've killed " + killed + " creatures! ::::::");
                Console.WriteLine(":::::                                                                ::::::");
                Console.WriteLine(":::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::");
                Console.WriteLine(":::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::");
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("Sadly, it ain't your time for the 'Grinder' tier... You've killed " + killed + " ceatures so far!");
            }
        }
    }
}
