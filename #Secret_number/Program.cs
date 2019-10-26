using System;

namespace _Secret_number
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            int secret = r.Next(101);
            bool flag = true;

            while(flag)
            {
                int guess = r.Next(101);
                
                if(guess > secret)
                {
                    Console.WriteLine("Your guess is Higher than the secret number!");
                }
                else if(guess < secret)
                {
                    Console.WriteLine("Your guess is Smaller than the secret mumber.");
                }
                else
                {
                    Console.WriteLine("Congratulations! You've guessed it! The number was "+ secret + ".");
                    flag = !flag;
                }
            }
        }
    }
}
