using MyConsole.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
//測試業務以及員工
namespace MyConsole
{
    internal class TestSalesEmployee
    {
        public static void Main()
        {
            Employee emp1 = new Employee()
            {
                id = 1,
                name = "Eric",
                address = "Taipei",
                phone = "0905366183",
                birthday = new DateTime(2001, 1, 1),
                salary = 50000
            }; //物件初始化

            Sales sales1 = new Sales(2, "Linda", "Taipei", 60000,1000000)
            {
                phone="0909912291",
                birthday=new DateTime(2002,1,1)
            };

            Sales sales2 = new Sales(3, "Tom", "Taipei", 1000000)
            {
                phone = "0302033494",
                birthday = new DateTime(2003, 3, 11),
                salary = 500000 //繼承來自Employee
            };

            //業績獎金計算
            sales1.actSalesAmount = 1000000;
            //業績獎金核算
            sales1.calCommision();
            //核算薪資
            emp1.calSalary(22, 100000);
            sales1.calSalary(22, 1000000);

            Console.WriteLine($"編號{emp1.id} 姓名{emp1.name} 底薪{emp1.salary} 生日{emp1.birthday} 實際薪資{emp1.ActSalary} ");
            Console.WriteLine($"編號{sales1.id} 姓名{sales1.name} 底薪{sales1.salary} 生日{sales1.birthday}");
            Console.WriteLine($"編號{sales2.id} 姓名{sales2.name} 底薪{sales2.salary} 生日{sales2.birthday} 業績{sales2.SalesAmount}");
        }
    }
}
