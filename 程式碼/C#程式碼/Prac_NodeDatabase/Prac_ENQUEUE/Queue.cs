using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prac_ENQUEUE
{
    internal class Queue
    {
        private int[] list = new int[10];

        public int Rear { get; set; } 
        public int Front { get; set; } 

        public void Enqueue(int data)
        {
            if((Rear+1)% list.Length==Front && Rear!=-1)
            {
                Console.WriteLine("眝列已滿");
                return;
            }
            Rear=(Rear+1)% list.Length;
            list[Rear]=data;
        }

        public void Dequeue()
        {
            if(Front==(Rear+1)% list.Length)
            {
                Console.WriteLine("眝列已滿");
                return;
            }
            Console.WriteLine("移除了" + list[Front]);
            Front = (Front + 1) % list.Length;
        }

        public void Display()
        {
            if(Front==(Rear+1) % list.Length)
            {
                Console.WriteLine("眝列已滿");
                return;
            }
            int i = Front;
            while(i!=Rear)
            {
                Console.WriteLine(list[i] + "");
                i=(i+1) % list.Length;
            }
            Console.WriteLine(list[Rear] + "");
            Console.WriteLine();
        }

    }
}
