using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Data
{
    internal class Node
    {
        public int Coef { get; set; } // 多項式項的係數
        public int Exp { get; set; }  // 多項式項的指數
        public Node Next { get; set; } // 下一個節點

        // 建構函數：初始化係數和指數
        public Node(int coef, int exp)
        {
            Coef = coef;
            Exp = exp;
            Next = null; // 預設下一個節點為 null
        }

    }
}
