using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prac_Node
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            LinkList list=new LinkList();
            list.CreateList();
            string line = new string('-', 25);

            Console.Write("輸入新值->");
            num=int.Parse(Console.ReadLine());
            //list.AddLast(num);
            //list.AddFirst(num);
            //list.InsertBehind(num,124);
            list.InsertArt(num, 3);
            list.PrintList();

            Console.ReadLine();
        }
    }
}
