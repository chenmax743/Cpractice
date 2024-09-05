using System;

namespace Rock_Paper_Scissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int playerScore = 0;
            int enemyScore = 0;

            Console.WriteLine("歡迎來到猜拳遊戲");

            while (playerScore !=3 && enemyScore !=3)
            {
                Console.WriteLine("玩家分數---" + playerScore + "對手分數---" + enemyScore);
                Console.WriteLine("按下 'R' 出石頭 ， 'P' 出布 ， 'S' 出剪刀");
                string playerChoice = Console.ReadLine();

                int EnemyChoice = random.Next(0, 3);

                if(EnemyChoice ==0)
                {
                    Console.WriteLine("敵人出了剪刀");

                    switch(playerChoice)
                    {
                        case "s":
                            Console.WriteLine("平手");
                            break;

                        case "r":
                            Console.WriteLine("你贏了");
                            playerScore++;
                            break;

                        default:
                            Console.WriteLine("敵人贏了");
                            enemyScore++;
                            break;
                    }
                }
                else if(EnemyChoice == 1)
                {
                    Console.WriteLine("敵人出了石頭");

                    switch(playerChoice)
                    {
                        case "r":
                            Console.WriteLine("平手");
                            break;

                        case "p":
                            Console.WriteLine("你贏了");
                            playerScore++;
                            break;

                        default:
                            Console.WriteLine("敵人贏了");
                            enemyScore++;
                            break;
                    }

                }
                else 
                {
                    Console.WriteLine("敵人出了布");

                    switch(playerChoice)
                    {
                        case "p":
                            Console.WriteLine("平手");
                            break;

                        case "s":
                            Console.WriteLine("你贏了");
                            playerScore++;
                            break;

                        default:
                            Console.WriteLine("敵人贏了");
                            enemyScore++;
                            break;
                    }
                }

            }

            if(playerScore == 3)
            {
                Console.WriteLine("玩家贏了");
            }
            else
            {
                Console.WriteLine("你輸了");
            }
        }
    }
}
