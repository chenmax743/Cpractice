using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("歡迎來到記事本");
            List<string> tasklist = new List<string>();
            string option = "";

            while(option !="e")
            {
                Console.WriteLine("今天想要做什麼?");
                Console.WriteLine("按下1增加要做的清單");
                Console.WriteLine("按下2移除增加的清單");
                Console.WriteLine("按下3觀看清單");
                Console.WriteLine("按下 'e' 退出應用程式");

                option = Console.ReadLine();

                if(option == "1")
                {
                    Console.WriteLine("輸入要做的事項");
                    string task = Console.ReadLine();
                    tasklist.Add(task);
                    Console.WriteLine("已新增到清單");
                }
                else if(option == "2")
                {
                    for(int i=0; i<tasklist.Count; i++)
                    {
                        Console.WriteLine(i + ":" + tasklist[i]);
                    }

                    Console.WriteLine("輸入2來移除新增的事項");
                    int taskNumber = Convert.ToInt32(Console.ReadLine());
                    tasklist.RemoveAt(taskNumber);
                }
                else if(option == "3")
                {
                    Console.WriteLine("觀看清單");

                    for(int i=0; i<tasklist.Count; i++)
                    {
                        Console.WriteLine(tasklist[i]);
                    }
                }
                else if(option == "e")
                {
                    Console.WriteLine("退出應用程式");
                }
                else
                {
                    Console.WriteLine("錯誤的選項，請在試一次");
                }
            }

            Console.WriteLine("感謝您的使用");
        }


    }
}

