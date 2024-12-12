using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prac__doublieStack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            stack.PushItem("Apple");
            stack.PushItem("Banana");
            stack.PushItem("Cherry");

            stack.PopItem();
            stack.PopItem();
            stack.PopItem();     
            
            Console.ReadLine();

        }
    }
}
