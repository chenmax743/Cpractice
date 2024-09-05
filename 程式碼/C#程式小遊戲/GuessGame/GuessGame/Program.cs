using System;

namespace GuessGame
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isCorrectGuess=false;
            Random random = new Random();
            int randomnum=random.Next(1,11);

            Console.WriteLine("歡迎來到猜數字遊戲");
            Console.WriteLine("猜一個一到十的數字");

            Console.WriteLine(randomnum);

            while(!isCorrectGuess)
            {
                Console.WriteLine("猜一個數字");
                int guess = Convert.ToInt32(Console.ReadLine());

                if(guess>randomnum)
                {
                    Console.WriteLine("太大了");
                }
                else if(guess<randomnum)
                {
                    Console.WriteLine("太小了");
                }
                else
                {
                    Console.WriteLine("恭喜猜對");
                    isCorrectGuess = true;
                }
                
                
            }
            Console.ReadKey();


        }
    }
}
