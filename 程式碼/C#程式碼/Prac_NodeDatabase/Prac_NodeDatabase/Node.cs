using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prac_NodeDatabase
{
   public  class Node
    {
        public int Coef {  get; set; }

        public int Exp {  get; set; }

        public Node Next {get; set; }

        public Node() { } 
        
        public Node(int data, int pow)
        {
            Coef = data;
            Exp = pow;
            Next = null;
        }
    }
}
