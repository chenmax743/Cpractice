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
            foreach (int n in number)
                AddLast(n);
        }

        public void AddLast(int data)
        {
            //指向目前節點的參考current，new運算子實體化新節點newNode
            Node current;
            Node newNode = new Node(data);

            //如果第一個節點first是空的，就把新節點設為第一個節點
            if (first == null)
                first = newNode;
            else //有第一個節點就走訪
            {
                current = first;
                while (current.Next != null) //走放串列到最後節點
                    current = current.Next;
                //目前節點的Next參考指向新節點
                current.Next = newNode;
            }
        }

        public void AddFirst(int data)
        {
            Node newNode = new Node(data) { Next = first };
            first = newNode;
        }

        /// <summary>
        /// 找到指定節點，將新節點加到指定節點之後
        /// </summary>
        /// <param name="data"></param>
        /// <param name="special"></param>

        public void InsertBehind(int data, int special)
        {
            Node current = first; //current參考指向first參考
            while (current != null) //遍歷找到指定的special Data
            {
                if (current.Data == special) //找到special Data
                    break;
                current = current.Next; //current的參考指向current下一個節點
            }
            if (current == null) //串列中沒有這個special節點
                Console.WriteLine($"串列中沒有節點{special}");
            else
            {
                Node newNode = new Node(data) { Next = current.Next };  //配置新節點記憶體，初始化新節點(新節點的Next參考指向current的Next，即當前的下一個位址)
                current.Next = newNode; //current的Next指向newNode物件(即newNode的記憶體位址指定給current.Next)
            }


        }

        public void RemoveFirst()
        {
            if (first == null) //檢查連結串列是否為空
                return;
            first=first.Next; //將first指向下一個節點
        }

        public void RemoveLast()
        {
            if (first == null)
                Console.WriteLine("此串列是空的");
            else if (first.Next == null)
                first = null;

            else
            {
                Node current = first;
                while (current.Next.Next != null)
                    current = current.Next;
                current.Next = null;
            }
        }

        /// <summary>
        /// 找到指定位置插入新節點
        /// </summary>
        /// <param name="data">新節點資料</param>
        /// <param name="pos">指定位置</param>

        public void InsertArt(int data,int pos)
        {
            int j;
            if (pos == 1) //如果指定位置為第一個，新節點加到首節點
            {
                AddFirst(data);
            }
            else
            {
                Node current = first; //目前的current參考指向first，即目前current在首節點
                for (j = 1; j < pos - 1; j++)//找到指定位置的前一個
                    current = current.Next; //current的參考指向current的Next(即current移動到下一個node)
                if (current == null) //如果找不到指定位置，只好說新節點只有這個位置可以插入
                    Console.WriteLine($"只有位置{j}可以插入");
                else
                {
                    Node newNode = new Node(data) { Next = current.Next }; //配置新節點記憶體(參考物件)，初始化新節點
                    current.Next = newNode; //current的Next指向newNode物件(即newNode的記憶體位置指定給current.Next)
                }
            }
        }
        public void PrintList()
        {
            Node current = first;
            if (current == null)
            {
                Console.WriteLine("鏈結串列是空的");
            }
            while (current != null)
            {
                Console.Write($"{current.Data,-5}");
                current = current.Next;
            }
        }

        public void ReverteNode()
        {
            Node previouse = null;
            Node current;

            while(first != null) 
            {
                current = first;
                first =current.Next;
                current.Next=previouse;
                previouse = current;
            }
            first = previouse;
        }
    }
}
