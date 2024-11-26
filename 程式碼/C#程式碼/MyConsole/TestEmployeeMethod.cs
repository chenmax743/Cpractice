using MyConsole.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsole
{
    internal class TestEmployeeMethod
    {
        public static void Main() 
        {
            //設定一個區域變數
            Employee emp1 = new Employee(); //建構一個員工物件
            //參考物件 設定相關Data Field / Property
            emp1.id = 1; //設定員工編號
            emp1.name = "Eric";
            emp1.salary = 50000;
            emp1.address = "Taipei";
            emp1.phone = "0905366183";
            emp1.birthday = new DateTime(2001, 1, 1);

            Employee emp2 = new Employee();
            emp2.id = 2;
            emp2.name = "Linda";
            emp2.salary = 40000;
            emp2.address = "Taipei";
            emp2.phone = "0905232443";
            emp2.birthday = new DateTime(2002, 2, 2);

            //使用建構子進行初始化 設定員工編號 姓名 地址
            Employee emp3 = new Employee(3,"Tom","Taipei")
            {
                phone = "091234345",
                birthday=new DateTime(2003,1,1),
                salary=30000
            };

            //核算薪水 呼叫物件方法

            emp1.calSalary(22, 10000);
            emp2.calSalary(22, 10000);

            Console.WriteLine($"編號{emp1.id} 姓名{emp1.name} 底薪{emp1.salary} 實際薪資{emp1.ActSalary}生日{emp1.birthday}");
            Console.WriteLine($"編號{emp2.id} 姓名{emp2.name} 底薪{emp2.salary} 實際薪資{emp2.ActSalary}生日{emp2.birthday}");
            Console.WriteLine($"編號{emp3.id} 姓名{emp3.name} 底薪{emp3.salary} 實際薪資{emp3.ActSalary}生日{emp3.birthday}");
        }
    }
}
