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

        public int Top { get; set; } = -1;

        public void ToPostfix(char[] infix, char[] postfix)
        {
            int pos = 0, k = 0;
            char token;

            while (infix[pos]!='\0')
            {
                if (infix[pos]=='(') 
                {
                    PushItem(stack, infix[pos]);
                    pos++;
                }
                else if (infix[pos]==')') 
                {
                    while ((Top != -1) && (stack[Top]!='('))
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
                postfix[k] = PopItem(stack);
                k++;
            }
            postfix[k] = '\0';
        }

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
