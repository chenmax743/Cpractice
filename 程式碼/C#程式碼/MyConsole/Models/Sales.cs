using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//業務員類別 繼承父親Employee
namespace MyConsole.Models
{
    public class Sales:Employee
    {
        //Data Field
        private Int32 _salesAmount;//業績
        private Int32 _commission;//佣金
        private Int32 _actSalesAmount;
        //自訂建構子
        //自訂建構子 明確指向父親建構子base() 指向父親特定建構子
        public Sales(Int32 id,String name,String address,Int32 salesAmount) : base(id,name,address)
        {
            _salesAmount = salesAmount; //目標業績
        }
        //建構子多載 Construtor Overloading
        public Sales(Int32 id, String name, String address, Int32 salary,Int32 salesAmount)
        {
            this.id = id;
            this.name= name;
            this.address= address;
            //業務起薪有一點邏輯 與員工不同
            if(salary>50000)
            {
                _salary=salary;  //protected member 沒有封裝
            }
            else
            {
                //50000起薪
                _salary = 50000;
            }
            _salesAmount= salesAmount; //目標業績
        }

        //實際業績屬性
        public int SalesAmount { get => _salesAmount; set => _salesAmount = value; }
        //唯獨屬性 業績獎金是經過計算的
        public int Commision { get => _commission; }

        public int actSalesAmount { get => _actSalesAmount; set => _actSalesAmount = value; }

        //Method--業績獎金核算
        public void calCommision()
        {
            if(_salesAmount>=_salesAmount*0.9)
            {
                _commission = (Int32)(_actSalesAmount * 0.01);
            }
        }

        //Overriding 複寫父親 Property(改版)
        public override int salary
        {
            set
            {
                if(value>5000)
                {
                    _salary=value;
                }
                else
                {
                    _salary = 50000;
                }
            }
            get
            {
                return _salary;
            }
        }

        //薪資核算方式進行改版 Overriding
        public override void calSalary(int days,int bons)
        {
            base.calSalary(days, bons); //呼叫方法
            //業績獎金加上去
            this._actSalary += _commission;
        }

    }
}
