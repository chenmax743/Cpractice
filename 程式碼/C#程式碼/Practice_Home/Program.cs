using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Home
{
    internal class Program
    {        
        static void Main(string[] args)
        {
            Student student=new Student();
            student.Name = "Max";
            student.Age = 18;


            student.DisplayInfo();

            student.Name = "";

            student.Age = 159;

            student.DisplayInfo();
            Console.ReadLine();
        }
    }
}

