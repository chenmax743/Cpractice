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

        public int Rear { get; set; } = -1;
        public int Front { get; set; } = 0;

        public void Enqueue(int data)
        {
            if(Rear>=9)
            {
                Console.WriteLine("嚀列已滿");
                return;
            }
            Rear++;
            list[Rear] = data;
        }

        public void Dequeue()
        {
            if(Rear==-1 || (Rear<Front))
                Console.WriteLine("無法刪除項目");
            
            else
            {
                Array.Clear(list, Front, 1);
                Front++;
            }
        }

        public void Display()
        {
            for(int i=0;i<list.Length; i++)            
                Console.Write($"{list[i],4}");
                Console.WriteLine();
                Console.WriteLine($"Rear = {Rear},Front = {Front}");
            
        }

    }
}
