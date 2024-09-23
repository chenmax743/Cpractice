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
            //string username;

            //console.writeline("請輸入您的大名 :");
            //username = console.readline();
            //console.writeline(username + "您好!");
            //console.readkey();

            //int i1 = 100;
            //int i2 = 200;
            //bool result;
            //result = (i1 > i2);

            //Console.WriteLine(result.ToString());

            //Console.ReadKey();

            //Console.WriteLine("輸入第一個數");
            //int iNum1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("輸入第二個數");
            //int iNum2 = Convert.ToInt32(Console.ReadLine());

            //if (iNum1 > iNum2)
            //{
            //    Console.WriteLine("比較大的數是" + iNum1);
            //}
            //else
            //{
            //    Console.WriteLine("比較大的是" + iNum2);
            //}
            //Console.ReadKey();
            //do { 
            //Console.WriteLine("輸入西元紀年");
            //int iNum1 = Convert.ToInt32(Console.ReadLine());


            //    if (iNum1 % 400 == 0)
            //    {
            //        Console.WriteLine(iNum1 + "閨年");
            //    }
            //    else if (iNum1 % 100 == 0)
            //    {
            //        Console.WriteLine(iNum1 + "非閨年");
            //    }
            //    else if (iNum1 % 4 == 0)
            //    {
            //        Console.WriteLine(iNum1 + "是閨年");
            //    }
            //} while (true);

            Console.WriteLine("101到200偶數累加為");
            int iSum = 0;
            int i = 101;

            while(i<=200)
            {
                if(i%2==0)
                {
                    iSum += i;
                }
                i++;
            }
            Console.WriteLine(iSum);
            Console.ReadKey();
                    
        }
    }
}
