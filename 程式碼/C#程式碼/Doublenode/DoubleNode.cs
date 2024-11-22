using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doublenode
{
    class DoubleNode
    {
        public int Data {  get; set; }

        public DoubleNode LLink { get;set;}

        public DoubleNode RLink { get;set;}

        public DoubleNode(int data)
        {
            Data = data;
            LLink = null;
            RLink = null;
        }
    }
}
