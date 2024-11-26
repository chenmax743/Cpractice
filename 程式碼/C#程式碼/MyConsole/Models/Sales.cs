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
        //自訂建構子
        //自訂建構子 明確指向父親建構子base() 指向父親特定建構子
        public Sales(Int32 id,String name,String address,Int32 salesAmount) : base(id,name,address)
        {
            _salesAmount = salesAmount; //目標業績
        }
        public int salesAmount { get => _salesAmount; set => _salesAmount = value; }
        //唯獨屬性 業績獎金是經過計算的
        public int Commision { get => _commission; }
    }
}
