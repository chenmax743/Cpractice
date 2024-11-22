using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseNode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CircularLinkedList circularLinkedList = new CircularLinkedList();
            //circularLinkedList.CreateList();
            //circularLinkedList.Display();
            //circularLinkedList.AddFirst(456);
            //circularLinkedList.Display();

            int opt, num, pos;
            CircularLinkedList list=new CircularLinkedList();
            list.CreateList();
            string line = new string('-', 25);
            Console.WriteLine(line);
            while (true) 
            {
                Console.WriteLine("1,輸出串列節點");
                Console.WriteLine("2,新節點 插到 第一個節點 之前");
                Console.WriteLine("3,新節點 插到 最後節點 之後");
                Console.WriteLine("4,刪除 指定節點");
                Console.WriteLine("5,結束選單");
                Console.WriteLine(line);

                Console.WriteLine("--請選取項目-->");
                opt= int.Parse(Console.ReadLine());

                switch(opt)
                    {
                    case 1:list.Display(); break;

                    case 2:
                        Console.Write("輸入新值-->");
                        num=int.Parse(Console.ReadLine());
                        list.AddFirst(num);
                        break;

                    case 3:
                        Console.Write("輸入新值-->");
                        num=int.Parse(Console.ReadLine());
                        list.AddLast(num);
                        break;

                    case 4:
                        Console.WriteLine("選擇欲刪除節點-->");
                        num=int.Parse(Console.ReadLine());
                        list.RemoveAt(num); break;

                    case 5:
                        Environment.Exit(0); break;
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
        
    }
}
