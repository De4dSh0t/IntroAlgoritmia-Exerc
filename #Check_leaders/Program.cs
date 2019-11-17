using System;

namespace _Check_leaders
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            int[] person = new int[20];
            int leader;
            bool l;

            for(int i = 0; i < person.Length; i++)
            {
                person[i] = r.Next(1, 120);
            }

            for(int i = 0; i < person.Length; i++)
            {
                int a = 1;

                for(int j = a; i < person.Length; i++)
                {
                    if(person[i] > person[j])
                    {
                        l = true;
                    }
                    else
                    {
                        l = false;
                    }

                    if(l == true)
                    {
                        leader ++;
                    }
                }

                a++;
            }

            Console.WriteLine(leader);
        }
    }
}
