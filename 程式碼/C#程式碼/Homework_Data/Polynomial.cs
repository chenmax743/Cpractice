using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Data
{
    internal class Polynomial
    {
        private Node item1, item2, result;
        public Polynomial()
        {
            result = null;
            item1 = null;
            item2 = null;
        }

        public Node CreateItem(Node A, int data, int pow)
        {
            Node newNode = new Node(data, pow);

            if (A == null) // 如果頭節點為空，直接返回新節點
            {
                A = newNode;
            }
            else
            {
                Node current = A;
                while (current.Next != null) // 遍歷到鏈表尾部
                {
                    current = current.Next;
                }
                current.Next = newNode; // 將新節點加入尾部
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

        public Node AddItem()
        {
            Node ptr1, ptr2, newNode;
            Node current = null;
            Node result = null;
            ptr1 = item1; // 第一個多項式鏈表
            ptr2 = item2;      // 第二個多項式鏈表

            while (ptr1 != null || ptr2 != null) // 當兩個鏈表都未結束時
            {
                newNode = new Node(0, 0); // 創建一個新的節點

                if ((ptr1 == null && ptr2 != null) ||
                    (ptr1 != null && ptr2 != null && ptr2.Exp > ptr1.Exp))
                {
                    // 第二個多項式節點的指數較大，選取 ptr2
                    newNode.Coef = ptr2.Coef;
                    newNode.Exp = ptr2.Exp;
                    ptr2 = ptr2.Next;
                }
                else if ((ptr2 == null && ptr1 != null) ||
                         (ptr1 != null && ptr2 != null && ptr1.Exp > ptr2.Exp))
                {
                    // 第一個多項式節點的指數較大，選取 ptr1
                    newNode.Coef = ptr1.Coef;
                    newNode.Exp = ptr1.Exp;
                    ptr1 = ptr1.Next;
                }
                else
                {
                    // ptr1 和 ptr2 的指數相等，係數相加
                    newNode.Coef = ptr1.Coef + ptr2.Coef;
                    newNode.Exp = ptr1.Exp;

                    ptr1 = ptr1.Next;
                    ptr2 = ptr2.Next;
                }

                // 如果係數為 0，則不儲存節點到結果中
                if (newNode.Coef != 0)
                {
                    if (result == null)
                    {
                        result = newNode; // 設定結果鏈表的第一個節點
                    }
                    else
                    {
                        current.Next = newNode; // 將新節點接到結果鏈表尾部
                    }
                    current = newNode; // 更新目前的節點
                }
                else
                {
                    newNode = null; // 如果係數為 0，丟棄節點
                }
            }

            return result; // 返回結果鏈表的頭節點
        }



        public void Display(Node result)
        {
            Node current = null;
            current = result;

            while (current != null) 
            {
                Console.Write($"{current.Coef}X^{current.Exp}");
                if (current.Next != null && current.Next.Coef > 0)
                    Console.Write("+");
                else Console.Write("");
                current = current.Next;
            }
            Console.WriteLine();
        }
    }
}
