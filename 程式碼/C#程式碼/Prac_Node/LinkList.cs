using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prac_Node
{
    class LinkList
    {
        private Node first;

        //定義預設建構函式--初始化第一個節點為空值
        public LinkList() 
        {
            first = null;
        }


        //直接以陣列產生鏈結串列
        public void CreateList()
        {
            //產生一維陣列並初始化
            int[] number = new int[3] { 65, 124, 43 };
            //讀取陣列元素，並呼叫成員方法AddList()將元素加到串列最後節點處
            foreach(int n in number)           
                AddLast(n);
            
        }

        public void AddLast(int data)
        {
            Node current;
            Node newNode = new Node(data);

            if(first ==null)
                first = newNode;
            else
            {
                current = first;
                while(current.Next != null)
                    current=current.Next;
                current.Next = newNode;
            }
        }

        public void PrintList()
        {
            Node current = first;
            if(current == null)
            {
                Console.WriteLine("鏈結串列是空的");
            }
            while(current != null) 
            {
                Console.WriteLine($"{current.Data,-5}");
                current = current.Next;
            }
        }
    }
}
