using MyConsole.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//建構員工們_只有員工 來的物件是Sales OR Engineer
namespace MyConsole
{
    internal class TestPoly
    {
        public static void Main()
        {
            //變數定義 採用公版(基底類別)來定義
            Employee emp1=null;
            //招募進來是一個業務員
            emp1 = new Sales(1, "Allen", "高雄市", 50000, 100000);
            emp1.birthday = new DateTime(2001, 1, 1);
            //設定時機業績?? 物件不可變 變數換個角色
            ((Sales)emp1).actSalesAmount = 100000;
            //業績獎金計算
            ((Sales)emp1).calCommision();
            emp1.calSalary(22, 10000);//會不會沒有加上業績獎金
            //輸出 員工資訊 實際薪水
            Console.WriteLine($"編號{emp1.id} 姓名{emp1.name} 底薪{emp1.salary} 生日{emp1.birthday} 實際薪資{emp1.ActSalary} ");
        }
    }
}
