using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Prac_StackLinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StackLinkedList list = new StackLinkedList();
            int data ,option;
            while (true) 
            {
                WriteLine("****堆疊的操作****");
                WriteLine("1.PUSH");
                WriteLine("2.POP");
                WriteLine("3.DISPLAY");
                WriteLine("4.PEEK");
                WriteLine("5.EXIT");
                Write("--請選取項目-->");
                option =int.Parse(Console.ReadLine());

                switch(option)
                {
                    case 1:
                        Write("輸入數值");
                        data = Convert.ToInt32(Console.ReadLine());
                        list.PushItem(data);
                        break;

                    case 2:
                        list.PopItem();
                        break;
                        case 3:
                        list.Display();
                        break;
                        case 4:
                        data=list.PeekItem();
                        if (data != -1)
                            WriteLine($"堆疊頂端元素[{data}]");
                        else
                            WriteLine("堆疊是空的");
                        break;
                        case 5:
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}
