using System;
using MyConsole.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//建構自行規劃類別
namespace MyConsole
{
    internal class TestEmployees
    {
        //Entry Point
        public static void Main()
        {
            //定義區域變數 類別是參考行別
            Employee emp1=null;

            //建構一個員工物件 使用預設建構子Default Constructor
            emp1 = new Employee();

            //物件沒有被參考
            //使用變數參考位址這一個個體(員工物件)
            emp1.salary = 50000;
            emp1.id = 18;
            emp1.name = "Eric";
            emp1.address = "Taipei";
            emp1.phone = "048708487";
            emp1.birthday = new DateTime(1998, 7, 4);

            int s =emp1.salary;
            

            //輸出
            Console.WriteLine($"編號:{emp1.id} 姓名:{emp1.name} 底薪:{s} 生日:{emp1.birthday}");

            //直接問類別 static 共用資料欄 問公司是
            Console.WriteLine(Employee.companyName);

            //透過static屬性問公司地址
            Console.WriteLine(Employee.companyAddress);
        }

    }
}
