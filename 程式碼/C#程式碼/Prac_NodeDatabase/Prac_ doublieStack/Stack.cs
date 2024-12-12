using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prac__doublieStack
{
    public class Stack
    {
        public string[] Name {  get; set; }=new string[5];
        public int Index { get; set; } = 0;

        public void PushItem(string data)
        {
            if(Index<Name.Length)
            {
                Name[Index] = data;
                Index++;
            }
            else
            {
                Console.WriteLine("堆疊已滿");
            }
        }

        //將元素從頂端彈出
        public void PopItem()
        {
            if (Index > 0)
            {
                Index--;
                Console.WriteLine($"{Name[Index]}");
            }
            else
                Console.WriteLine("堆疊丟完了");
        }
    }

    
}
