using Prac_Node;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseNode
{
    class CircularLinkedList
    {
        private Node first;
        public void CreateList()
        {
            int[] number = new int[] { 65, 124, 43, 255 };
            foreach (int i in number)
                AddLast(i);
        }

        public void Display()
        {
            Node current;           
            if(first==null)
            {
                Console.WriteLine("鏈結串列是空的");
                return;
            }
            else
            {
                current = first;
                while (current!=null) 
                {
                    Console.Write($"[{current.Data,3}]->");
                    current=current.Next;
                    if (current == first)
                        break;
                }
                Console.WriteLine();
            }
        }

        public void AddLast(int data)
        {
            Node current;
            Node newNode = new Node(data);

            if(first==null)
            {
                first = newNode;
                newNode.Next = newNode;
            }
            else
            {
                current=first;
                while(current.Next!=first)
                    current=current.Next;
                current.Next = newNode;
                newNode.Next=first;
            }
        }

        public void AddFirst(int data)
        {
            Node newNode = new Node(data) { Next = first };
            Node current = first;
            if (first == null)
                newNode.Next = newNode;
            else
            {
                while (current.Next != first)
                    current = current.Next;
                current.Next = newNode;
            }
            first = newNode;
        }

        public void RemoveAt(int data)
        {
            Node current, previous;
            if(first.Data==data)
            {
                current = first;
                while(current.Next != first)
                    current=current.Next;
                current.Next = first.Next;
                first=first.Next;
                Console.WriteLine($"[{first.Data}]已被移除");
            }
            else
            {
                current = first;
                while(current.Next != first)
                {
                    previous = current;
                    current=current.Next;
                    if(current.Data==data)
                    {
                        previous.Next = current.Next;
                        current = current.Next;
                    }
                }
            }
        }
    }
}
