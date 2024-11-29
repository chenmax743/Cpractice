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
            int j = 0;
            for(int i=0; i<infix.Length;i++)
            {
                char ch=infix[i];
                if (char.IsLetter(ch))
                {
                    postfix[j++] = ch;
                }
                else if (ch == '(')
                {
                    PushItem(ch);
                }
                else if (ch == ')')
                {
                    while(Top !=1 && stack[Top]!='(')
                    {
                        postfix[j++] = PopItem();
                    }
                    PopItem();
                }
                else
                {
                    while(Top!=-1 && Priority(stack[Top])>=Priority(ch))
                    {
                        postfix[j++] = PopItem();
                    }
                    PushItem(ch);                   
                }
            }
            while(Top !=-1)
            {
                postfix[j++] = PopItem();
            }
        }

        public int Priority(char op)
        {
            switch(op)
            {
                case '+':
                case '-':
                    return 1;
                case '*':
                case '/':
                    return 2;
                case '(':
                    return 0;
                default:
                    return -1;
            }
        }

        public void PushItem(char op)
        {
            if(Top <stack.Length-1)
            {
                stack[Top] = op;
            }
        }

        public char PopItem()
        {
            if(Top>0)
            {
                return stack[Top--];
            }
            return '\0';
        }
    }
}
