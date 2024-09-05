using System;

namespace Dice_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            int playerRandomNum;
            int enemyRandomNum;

            int PlayerPoint = 0;
            int EnemyPoint = 0;

            Random randon = new Random();

            for(int i =0; i<10;i++)
            {
                Console.WriteLine("按下按鈕投擲子");

                Console.ReadKey();
                playerRandomNum = randon.Next(1,7);
                Console.WriteLine("你投出了" + playerRandomNum);

                Console.WriteLine("......");
                System.Threading.Thread.Sleep(1000);

                enemyRandomNum = randon.Next(1, 7);
                Console.WriteLine("對手投出了" + enemyRandomNum);

                if(playerRandomNum>enemyRandomNum)
                {
                    PlayerPoint++;
                    Console.WriteLine("你贏了");
                }
                else if(playerRandomNum<enemyRandomNum)
                {
                    EnemyPoint++;
                    Console.WriteLine("你輸了");
                }
                else
                {
                    Console.WriteLine("平手");
                }
                Console.WriteLine("結算");
                Console.WriteLine("玩家分數:" + PlayerPoint);
                Console.WriteLine("敵人分數" + EnemyPoint);
                
            }

            if(PlayerPoint>EnemyPoint)
            {
                Console.WriteLine("恭喜玩家獲勝");
            }
            else if(PlayerPoint < EnemyPoint)
            {
                Console.WriteLine("你好菜");  
            }
            else
            {
                Console.WriteLine("平局");
            }

            Console.ReadKey();
            
        }
    }
}
