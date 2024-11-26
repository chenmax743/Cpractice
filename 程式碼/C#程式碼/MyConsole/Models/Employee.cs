using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//規劃員工類 雛形
namespace MyConsole.Models
{
    //設定public修飾詞(Modifier)可見度(影響如何被看見 被使用或者被衍生當作父類別)
    //public 公開的可以被看見 可以被使用 可以被衍生類別(跨專案)
    public class Employee
    {
        //Data Field(可以儲存資訊)特徵
        public Int32 id;//員工編號
        public String name;//員工姓名
        private Int32 _salary;//員工薪資
        public String phone;//員工電話
        private DateTime _birthday;//員工生日
        public String address;

        //實際薪水Data Field
        private Int32 _actSalary;

        //公用資料欄Data Field(靜態) class Member
        public const String companyName = "夢想電腦";
        private static String _companyAddress = "台北市信義區";  //可以改變

        //編譯時產生建構子Constructor(空參數的)
        //Instance Proprty
        //規劃屬性 Property(代理一個被封裝資料欄位) 可以雙向setter and getter(也可以單向)

        public Int32 salary
        {
            //設定區段
            set
            {
                if(value > 30000) 
                {
                    _salary = value;
                }
                else 
                {
                    _salary = 30000;
                }
            }
            //取得區段
            get 
            {
                return _salary;
            }
        }

        //生日Property
        public DateTime birthday
        {
            set 
            {
                //取出系統日期 Nor Property getter
                DateTime today = DateTime.Now;

                //輸入生日與今天差異計算
                TimeSpan span=today-value;
                //取得天數差異 
                Int32 year=(Int32)(span.Days/362.25);
                //是否年滿18
                if(year>=18)
                {
                    _birthday = value;
                }
            }
            get
            {
                return _birthday;
            }
        }

        public static String companyAddress
        {
            get
            {
                return _companyAddress;
            }
        }

        //使用Lamba Expression 進行屬性實作 setter(唯獨屬性)
        public int ActSalary { get => _actSalary;}

        //Method 薪資核算
        //定義第一行定義 抽象描述 Instance Method 個別物件存在的方法

        public void calSalary(Int32 days,Int32 bons)
        {
            //出勤天數
            if(days < 0)
            {
                _actSalary = (Int32)(days / 22.0 * _salary) + bons;
            }
            //功能實作
        }

    }
}
