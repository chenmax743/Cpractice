using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prac_threetree
{
    class InfitTofoxfix
    {
        private char[] stack = new char[20];

        public int Top { get; set; } = -1; //指向堆疊頂端

        public void ToPostfix(char[] infix, char[] postfix)
        {
            int pos = 0, k = 0;
            char token;

            while (infix[pos]!='\0') //0表示空字符
            {
                if (infix[pos]=='(') //左括號押入STACK
                {
                    PushItem(stack, infix[pos]);    //呼叫堆疊的PUSHT()方法
                    pos++;
                }
                else if (infix[pos]==')')   //右括號從堆疊彈出 
                {
                    while ((Top != -1) && (stack[Top]!='('))    //輸出運算式到左括號
                    {
                        postfix[k++] = PopItem(stack);  
                        k++;
                    }
                    if(Top==-1)
                    {
                        Console.WriteLine("運算式不正確");
                        break;
                    }
                    token = PopItem(stack);
                    pos++;
                }
                else if (Char.IsDigit(infix[pos]) || Char.IsLetter(infix[pos])) 
                {
                    postfix[k] = infix[pos];
                    k++;
                    pos++;
                }
                else if (infix[pos]=='+'|| infix[pos]=='-'
                      || infix[pos]=='*'||infix[pos]=='/' 
                      || infix[pos]=='%')
                {

                    while((Top!= -1) && (stack[Top]!='(') 
                         && (Priority(stack[Top])
                         >= Priority(infix[pos]))) 
                    {
                        postfix[k]=PopItem(stack);
                        k++;
                        
                    }
                    PushItem(stack, infix[pos]);
                    pos++;
                }
                else
                {
                    Console.WriteLine("運算的漢字不對");
                    break;
                }
            }
            while((Top!=-1) && (stack[Top]!='('))
            {
                postfix[k] = PopItem(stack); //彈出堆疊內其他運算子
                k++;
            }
            postfix[k] = '\0'; 
        }

        //依先乘除後加減的優先權
        public int Priority(char op)
        {
            switch (op) 
            {
                case '*': case '/': case '%': return 2;
                case '+':
                case '-': return 1;
                default: return 0;
            }
        }

        //將項目押入堆疊
        public void PushItem(char[] stack,char value)
        {
            if (Top == stack.Length - 1)
                Console.WriteLine("堆疊已滿");
            else
            {
                Top++;
                stack[Top] = value;
            }
            
        }

        //從堆疊彈出項目
        public char PopItem(char[] stack)
        {
            char val = ' ';
            if(Top==-1) 
            {
                Console.WriteLine("堆疊是空的");
            }
            else
            {
                val = stack[Top];
                Top--;
            }
            return val;
            
        }
    }
}
