using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prac_StackLinkedList
{
    class StackLinkedList
    {
        private Node Top;
        public int Size { get; set; } = 0;

        public StackLinkedList()
        { Top = null; }

        public void PushItem(int data)
        {
            Node newNode = new Node(data) { Next = Top };
            Top = newNode;
            Size++;
        }

        //從堆疊頂端彈出項目
        public void PopItem() 
        {
            Node current = Top;

            if (Top != null)
            {
                Top = Top.Next; //沒有被參考的Node會自動回收
                Console.WriteLine($"堆疊頂端彈出的項目{current.Data}");
                Size--;
            }
            else
                Console.WriteLine("堆疊是空的");
        }

        //回傳堆疊頂端元素
        public int PeekItem()
        {
            if (Top != null)
                return Top.Data;
            else
                return -1;
        }

        //輸出堆疊內容
        public void Display()
        {
            Node current = Top; //指向目前節點的參數
            if (Top == null)
                Console.WriteLine("鏈結串列是空的");
            else
            {
                //空串列不是空的情況下讀取節點
                while(current != null) 
                {
                    Console.Write($"[{current.Data}]->");
                    current=current.Next;
                }
                Console.WriteLine();
            }
        }
    }
}
