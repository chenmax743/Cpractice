using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Home
{
    class Student
    {
        private string name;
        private int age;

        public string Name
        {
            get { return name; }
            set
            {
                if (name == null)
                {
                    name = value;
                }
                else
                {
                    Console.WriteLine("名稱不能為空");
                }
            }
        }

        public int Age
        {
            get { return age; }
            set
            {
                if(value>=0 && value<=120)
                {
                    age = value;
                }
                else
                {
                    Console.WriteLine("請輸入有效年齡");
                }
            }
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"學生姓名:{Name},年齡:{Age}");
        }
        
    }
}
