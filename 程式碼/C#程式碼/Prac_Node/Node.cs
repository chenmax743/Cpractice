using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prac_Node
{
    class Node //定義串列連結節點
    {
        public int Data {  get; set; } //資料欄
        public Node Next { get; set; } //鏈結欄,指向下一個節點

        //定義建構函式-傳入數值
        public Node(int data)
        {
            Data = data;
            Next = null;
        }
    }
}
