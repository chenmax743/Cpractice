using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prac_Database
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Student student = new Student();

            student.Name = "多拉A夢";
            student.Age = 25;

            student.Display();

           

            Console.ReadLine();
        }
    }
}
