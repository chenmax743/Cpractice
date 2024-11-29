using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prac_threetree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            InfitTofoxfix express = new InfitTofoxfix();
            char[] infix = new char[20];
            char[] posfix = new char[20];
            Console.WriteLine("輸入中序運算式-->");
            string word = Console.ReadLine();
            for(int j=0;j<word.Length;j++)
                infix[j] = word[j];
            express.ToPostfix(infix, posfix);
            Console.WriteLine("--中序轉為後續運算式--");
            Console.WriteLine(posfix);
            Console.ReadKey();
        }
    }
}
