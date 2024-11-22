using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prac_DoublyNode
{
    class DoublyNode
    {
        public int Data {  get; set; }
        public DoublyNode LLink { get; set; }
        public DoublyNode  Rlink { get; set;}

        public DoublyNode(int data)
        {
            Data = data;
            LLink = null;
            Rlink = null;
        }
    }
}
