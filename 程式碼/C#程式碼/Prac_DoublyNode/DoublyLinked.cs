using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prac_DoublyNode
{
    class CircularDoublyLinked
    {
        public DoublyNode first, Last;

        public int Count { get; set; } = 0;

        public CircularDoublyLinked()
        {
            first = null;
            Last = null;
        }

        public void CreateList()
        {
            int[] number = new int[4] { 65, 124, 43, 255 };
            foreach(int n in number)
                AddLast(n);
        }

        public void Display()
        {
            DoublyNode current;
            if (first == null)
                Console.WriteLine("鏈結串列是空的");
            current = first;

            while (current != null) 
            {
                Console.WriteLine($"[{current.Data}]->");
                current=current.Rlink;
                if (current == first)
                    break;
            }
            Console.WriteLine($"\n節點數:{Count}");
        }

        public void AddFirst(int data)
        {
            DoublyNode newNode = new DoublyNode(data) { Rlink = first };

            if(first==null)
            {
                first=newNode;
                Last = newNode;
            }
            else
            {
                first.Rlink = newNode;
                first=newNode;
                first.LLink = Last;
                Last.Rlink = first;
            }
            Count++;

        }

        public void AddLast(int data) 
        {
            DoublyNode newNode = new DoublyNode(data);
            if(Last == null)
            {
                first = newNode;
                Last=newNode;
            }
            else
            {
                Last.Rlink = newNode;
                Last=newNode;
                Last.LLink = first;
                first.Rlink= Last;
            }
        }

        public void RemoveLast()
        {
            if(Last == null)
                Console.WriteLine("鏈結串列是空的");
            else if(Count==1)
            {
                DoublyNode current = Last.LLink;
                Last.LLink = null;
                Last = current;
                Last.Rlink= first;
                first.LLink=Last;
                Count--;
            }
        }

        public void RemoveFirst()
        {
            if (first == null)
                Console.WriteLine("鏈結串列是空的");
            else if(Count==1)
            {
                first = null;
                Last=null;
                Count--;
            }
            else
            {
                DoublyNode current=first.Rlink;
                first.Rlink= null;
                first = current;
                first.LLink = Last;
                Last.Rlink= first;
                Count--;
            }
        }
    }
}
