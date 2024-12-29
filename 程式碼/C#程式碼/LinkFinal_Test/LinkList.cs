using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkFinal_Test
{
    class LinkedList
    {
        private Node head;

        public void AddLast(Character data)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
        }



        //替換角色
        public void Replace(int position, Character newCharacter)
        {
            Node current = head;
            int index = 0;

            while (current != null)
            {
                if (index == position)
                {
                    current.Data = newCharacter;
                    return;
                }
                current = current.Next;
                index++;
            }

            Console.WriteLine("替換失敗，無效的位置！");
        }
        //輸出隊伍
          public void DisplayTeam()
        {
            if (head == null)
            {
                Console.WriteLine("隊伍為空！");
                return;
            }

            Node current = head;
            int index = 1;
            while (current != null)
            {
                Console.WriteLine($"[{index}] {current.Data}");
                current = current.Next;
                index++;
            }
        }

        public int Count()
        {
            int count = 0;
            Node current = head;
            while (current != null)
            {
                count++;
                current = current.Next;
            }
            return count;
        }

        public void Sort()
        {
            if (head == null || head.Next == null)
                return;

            List<Character> characters = new List<Character>();
            Node current = head;
            while (current != null)
            {
                characters.Add(current.Data);
                current = current.Next;
            }

            characters.Sort((c1, c2) => c2.Attack.CompareTo(c1.Attack));

            current = head;
            foreach (var character in characters)
            {
                current.Data = character;
                current = current.Next;
            }
        }
    }
}