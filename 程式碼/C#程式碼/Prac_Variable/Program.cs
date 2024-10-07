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
            int  i, j;
            int[] v = new int[5];
            for(i=0;i<5;i++)
            {
                Console.WriteLine($"輸入五{i+1}個數字");
                v[i] = int.Parse( Console.ReadLine() );
            }
            for(i=0;i<5;i++)
            {
                for(j=0;j<4-i;j++)
                {
                    if (v[j] > v[j+1])
                    {
                        int t = v[j];
                        v[j] = v[j+1];
                        v[j+1] = t;

                    }
                }
            }

            for(i=0;i<5; i++)
            {
                Console.WriteLine(v[i]);
            }
          
            


            Console.ReadLine();
            

        }
    }
}
