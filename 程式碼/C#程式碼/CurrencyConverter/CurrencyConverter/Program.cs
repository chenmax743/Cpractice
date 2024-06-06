using System;
using System.Text;
using System.Threading.Tasks;

namespace Currency
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("按下 'C' 使用轉換器或是按下其他按鈕使用溫度轉換器");
            string answer = Console.ReadLine();

            if(answer == "c")
            {
                Console.WriteLine("你選擇了貨幣轉換器");
                Console.WriteLine("按下 'A' 使用貨幣轉換器");

                string choice = Console.ReadLine();

                if (choice == "a")
                {
                    Console.WriteLine("請輸入要轉換成歐元的數值");
                    float pounds = float.Parse(Console.ReadLine());
                    float euros = pounds * 1.16f;
                    Console.WriteLine("轉換成歐元的金額為" + euros.ToString("0.00"));
                }
                else
                {
                    Console.WriteLine("輸入要轉換的歐元金額");
                    float euros = float.Parse(Console.ReadLine());
                    float pound = euros / 1.16f;

                    Console.WriteLine("你轉換的金額為" + pound.ToString("0.00"));
                }
            }

            else
            {
                Console.WriteLine("歡迎來到溫度轉換器");
                Console.WriteLine("按下 'A' 轉換你想要的氣溫");

                string choice = Console.ReadLine();

                if(choice == "a")
                {
                    Console.WriteLine("輸入想要調整的溫度");
                    float clecius = float.Parse(Console.ReadLine());
                    float farenheit = clecius * 1.8f + 32f;
                    Console.WriteLine("溫度計的溫度為" + farenheit);
                }
                else
                {
                    Console.WriteLine("請輸入華氏溫度");
                    float faranheit = float.Parse(Console.ReadLine());
                    float celcuis = (faranheit - 32f) / 1.8f;
                    Console.WriteLine("當前攝氏溫度為" + celcuis);
                }
            }
        }
    }
}
