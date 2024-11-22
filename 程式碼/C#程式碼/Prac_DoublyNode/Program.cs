using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prac_DoublyNode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opt, num;
            CircularDoublyLinked list = new CircularDoublyLinked();
            list.CreateList();
            string line = new string('-', 25);
            Console.WriteLine(line);
            while (true)
            {
                Console.WriteLine("1,輸出串列節點");
                Console.WriteLine("2,新節點插到 第一個節點 之後");
                Console.WriteLine("3,新節點插到 最後節點 之前");
                Console.WriteLine("4,新增節點到 指定位置");
                Console.WriteLine("5,刪除 第一個節點");
                Console.WriteLine("6,刪除最後一個節點");
                Console.WriteLine("7,結束選單");
                Console.WriteLine(line);

                Console.Write("--請選取項目-->");
                opt = int.Parse(Console.ReadLine());

                switch (opt)
                {
                    case 1: list.Display(); break;
                    case 2:
                        Console.Write("輸入新值-->");
                        num = int.Parse(Console.ReadLine());
                        list.AddLast(num);
                        break;
                    case 3:
                        Console.Write("輸入新值-->");
                        num = int.Parse(Console.ReadLine());
                        list.AddFirst(num);
                        break;
                    
                        break;
                    case 4: list.RemoveFirst(); break;
                    case 5: list.RemoveLast(); break;
                    case 9: Environment.Exit(0); break;
                }
            }
        }
    }
}
