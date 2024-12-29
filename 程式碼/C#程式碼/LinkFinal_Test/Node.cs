using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkFinal_Test
{
    class Node
    {
        public Character Data { get; set; }
        public Node Next { get; set; }

        public Node(Character data)
        {
            Data = data;
            Next = null;
        }
    }
}
