using System;

namespace ShapeArea
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer;
            float result;
            Console.WriteLine("今天要測量什麼?，直角行案'r',其他按任何案件");

            answer = Console.ReadLine();

            if(answer == "r")
            {
                Console.WriteLine("輸入直角的長度");
                float height = float.Parse(Console.ReadLine());

                Console.WriteLine("輸入直角寬度");
                float width = float.Parse(Console.ReadLine());

                result = height / width;
            }
            else
            {
                Console.WriteLine("輸入圓形直徑");
                float radius = float.Parse(Console.ReadLine());

                result = (float)Math.PI * (radius * radius);
            }

            Console.WriteLine("測量結果為"+result);
            Console.ReadLine();

            
        }
    }
}
