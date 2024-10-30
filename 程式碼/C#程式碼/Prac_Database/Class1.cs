using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prac_Database
{
    class Student
    {
        public string studentName;

        public int age;

        public string Name
        {
            get { return studentName; }
            set
            {
                if (studentName == null)
                {
                    studentName = value;
                }
                else
                {
                    Console.WriteLine("名稱不能流空");
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
                    age=value;
                }
                else
                {
                    Console.WriteLine("輸入有效名稱");
                }
            }

        }

        public void Display()
        {
            Console.WriteLine($"學生姓名:{Name},年齡:{Age}");
        }

        
    }
}
