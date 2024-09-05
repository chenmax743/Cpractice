using System;
namespace BaseGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int playerHP = 40;
            int enemyHP = 20;

            int playerAttack = 5;
            int enemyAttack = 7;

            int healAmount = 5;
            int flameArrow = 10;

            Random random = new Random();

            while(playerHP>0 && enemyHP>0)
            {
                Console.WriteLine("--Player turn--");
                Console.WriteLine("玩家血量" + playerHP + "敵人血量" + enemyHP);
                Console.WriteLine("按下 'a' 攻擊 ， 按下 'h' 恢復");
                

                string choice = Console.ReadLine();

                if(choice == "a")
                {
                    enemyHP -= playerAttack;
                    Console.WriteLine("玩家對敵人造成了 " + playerAttack + "傷害!");
                }
                else if(choice =="h")
                {
                    playerHP += healAmount;
                    Console.WriteLine("玩家治療了" + healAmount + "滴血!");
                }
                else
                {
                    flameArrow -= playerAttack;
                    Console.WriteLine("flame attack");
                }
                //敵人的回合

                if(enemyHP>0)
                {
                    Console.WriteLine("--Enemy turn--");
                    Console.WriteLine("玩家血量" + playerHP + "敵人血量" + enemyHP);
                    int EnemyChoice = random.Next(0, 2);

                    if(EnemyChoice ==0)
                    {
                        playerHP -= enemyAttack;
                        Console.WriteLine("敵人對你造成了" + enemyAttack + "傷害");
                    }
                    else
                    {
                        enemyHP += healAmount;
                        Console.WriteLine("敵人回復了" + healAmount + "滴血");
                    }
                }

            }

            if (playerHP > 0)
            {
                Console.WriteLine("恭喜勝利");
            }
            else
            {
                Console.WriteLine("你輸了");
                
            }
        }
    }
}
