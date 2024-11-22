using System; //引用命名空間
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsole
{
    class TestString
    {
        //主程式 Entry Point static 修飾詞 直接抽出來執行
        public static void Main()
        {
            Int32 slary = 50000;
            //建構Constructor 一個個體字串物件
            //Class 就是 Data Type
            String Name; //定義一個變數變數 類型string
            //建構一個字串物件
            //Name = "Eric"; //賦值Assign Eric 先建構一個物件 指派給Name
            Name = new string(new Char[] {'E','R','I','C'});
            //輸出
            Console.Write(Name); //name變數儲存位址 參考那一個字串 進行輸出
            //操作物件 屬性Prorprty or MetHod or Data Field or UI Event
            Int32 len=Name.Length;//屬性Prperty(程序)getter 回應一個值
            Console.WriteLine(len);

            //操作物件方法 Method
            String newName=Name.ToUpper(); //轉大寫方法呼叫 產生一個新的字串物件
            Console.WriteLine(len);
            Console.WriteLine(newName);
            Type t=Name.GetType(); //取的物件型別 GetType()方法 繼承來自根類別Object
            Console.WriteLine(t);
            
        }
    }
}
