using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doublenode
{
    class DoublyLink
    {
        private DoubleNode first, last;

        public int Count { get; set; } = 0;

        public DoublyLink()
        {
            first=null;
            last=null;
        }

        public void CreateList()
        {
            int[] number=new int[4] {65,124,43,255};
            foreach (int i in number)
                AddLast(i);
        }

        public void Display()
        {
            DoubleNode current;
            if (first == null)
                Console.WriteLine("鏈結串列是空的");
            current = first;

            while(current != null)
            {
                Console.Write($"[{current.Data}]->");
                current=current.RLink;
            }
            Console.WriteLine($"\n節點數:{Count}");
        }

        public void AddFirst(int data)
        {
            DoubleNode newNode=new DoubleNode(data);

            if(first == null)
            {
                first = newNode;
                last = newNode;
            }
            else
            {
                newNode.RLink = first;
                first.LLink = newNode;
                first = newNode;
            }
            Count++;
        }



        public void AddLast(int data)
        {
            DoubleNode newNode=new DoubleNode(data);

            if(last==null)
            {
                first= newNode;
                last= newNode;
            }
            else
            {
                last.RLink=newNode;
                newNode.LLink = last;
                last= newNode;
            }
            Count++;
        }

        public void RemoveFirst() 
        {
            if (first == null)
                Console.WriteLine("空的鏈結串列，沒有節點可刪除");
            else if(Count==1)
            {
                first = null;
                last = null;
                Count--;
            }
            else
            {
                DoubleNode current =first.RLink;
                first.RLink = null;
                first=current;
                first.LLink = null;
                Count--;
            }
        }

        public void RemoveLast()
        {
            if (last == null)
                Console.WriteLine("空的鏈結串列,沒有節點可刪除");
            else if(Count==1)
            {
                first = null;
                last = null;
                Count--;
            }
            else
            {
                DoubleNode current = last.LLink;
                last.LLink = null;
                last= current;
                last.RLink = null;
                Count--;
            }
        }

        public void InsertAt(int data,int pos)
        {
            DoubleNode newNode;
            int j;

            if(pos==1)
                AddFirst(data);
            else if(pos>=Count)
                AddLast(data);
            else
            {
                DoubleNode current = first;
                for(j=1;j<pos&&current!=null;j++)
                    current=current.RLink;

                newNode = new DoubleNode(data)
                {
                    RLink = current,
                    LLink = current
                };
                current.LLink = newNode;
                newNode.LLink.RLink = newNode;
                
                Count++;
            }
        }
    }
}
