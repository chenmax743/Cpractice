using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prac_Variable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] num = new int[3][];
            num[0] = new int[4];
            num[1] = new int[3];
            num[2] = new int[5];

            for(int i=0; i<num.Length; i++) 
            {
                for(int j = 0; j < num[i].Length; j++)
                {
                    num[i][j] = j;
                    Console.Write(num[i][j] +" ");
                }
                Console.WriteLine();
            }




















            Console.ReadLine();
        }
    }
}
