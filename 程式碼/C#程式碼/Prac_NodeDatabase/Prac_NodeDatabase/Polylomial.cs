using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prac_NodeDatabase
{
    public class Polylomial
    {
        private Node item1, item2, result;

        public Polylomial()
        {
            result = null;
            item1 = null;
            item2 = null;
        }

        public Node CreateItem (Node A,int data ,int pow)
        {
            Node current;
            Node newNode = new Node(data, pow);

            if (A == null)
                A = newNode;
            else
            {
                current = A;
                while(current.Next!=null)
                    current=current.Next;
                current.Next = newNode;
            }
            return A;

        }

        public Node ShowPoly1()
        {
            item1 = CreateItem(item1, 3, 7);
            item1 = CreateItem(item1, 8, 4);
            item1 = CreateItem(item1, 1, 3);
            item1 = CreateItem(item1, 7, 1);
            return item1;
        }

        public Node ShowPoly2()
        {
            item2 = CreateItem(item2, 4, 5);
            item2 = CreateItem(item2, 6, 4);
            item2 = CreateItem(item2, -2, 1);
            return item2;
        }

        public void Display(Node result)
        {
            Node current = null;
            current=result;

            while(current!=null)
            {
                Console.Write($"{current.Coef}X^{current.Exp}");
                if (current.Next != null && current.Next.Coef > 0)
                    Console.Write("+");
                else Console.Write("");
                current = current.Next;
            }
            Console.WriteLine();
        }

        public Node AddItem()
        {
            Node ptr1, ptr2, newNode;
            Node current = null;
            ptr1 = item1;
            ptr2 = item2;

            while (ptr1 != null || ptr2 != null)
            {
                newNode = new Node() { Next = null };
                if(ptr1 != null && (ptr2==null || ptr1.Exp>ptr2.Exp))
                {
                    newNode.Coef= ptr1.Coef;
                    newNode.Exp= ptr1.Exp;
                    ptr1=ptr1.Next;
                }
                else if(ptr1==null || ptr1.Exp<ptr2.Exp)
                {
                    newNode.Coef=ptr2.Coef;
                    newNode.Exp = ptr2.Exp;
                    ptr2=ptr2.Next;
                }
                else
                {
                    newNode.Coef = ptr1.Coef + ptr2.Coef;
                    newNode.Exp = ptr1.Exp;

                    if(ptr1 != null) ptr1 = ptr1.Next;
                    if(ptr2 != null) ptr2 = ptr2.Next;
                }

                if (newNode.Coef != 0)
                {
                    if (result == null)
                        result = newNode;
                    else
                        current.Next = newNode;
                    current = newNode;
                }
                else
                    newNode = null;
            }
            return result;
        }
    }
}
