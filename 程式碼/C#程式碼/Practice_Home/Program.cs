using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Home
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random dice = new Random();
            int iRoll1=dice.Next(1,7);
            int iRoll2=dice.Next(1,7);
            int iRoll3=dice.Next(1,7);

            int total = iRoll1 + iRoll2 + iRoll3;

            

            Console.WriteLine($"Dice Roll :{iRoll1}+{iRoll2}+{iRoll3}={total}");

            if (total > 14)
            {
                Console.WriteLine("You Win");
            }
            if (total < 15)
            {
                Console.WriteLine("You Lose");
            }
            




            Console.ReadKey();
        }
    }
}
