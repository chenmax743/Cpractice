using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//工程師是員工
namespace MyConsole.Models
{
    //繼承父類別Employees
    public class Engineer:Employee
    {
        private Int32 _techBons;
        private String _tech;

        public Engineer(Int32 id,String name,String address,Int32 Salary,String tech,Int32 techBons):base(id,name,address)
        {
            this.salary = Salary; //override父親屬性salary進行設定
            this._tech = tech;
            this._techBons = techBons;
        }

        //Property設定
        public int TeachBons { get => _techBons; set=>_techBons = value; }

        public String Teach { get => _tech; set => _tech = value; }

        //Overriding(四大一樣 修飾詞/回應值/方法名稱/參數列 父親薪資核算 加上技術津貼)

        public override void calSalary(int days, int bons)
        {
            base.calSalary(days, bons);
            //加上技術津貼
            this._actSalary += this._techBons;
        }
    }
}
