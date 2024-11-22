using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prac_NodeDatabase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Node result = null;
            Polylomial poly = new Polylomial();
            string line = new string('-', 35);
            Console.WriteLine(line);
            Console.WriteLine("多項式的表示:X^B");

            Console.WriteLine("第一個多項式");
            result = poly.ShowPoly1();
            poly.Display(result);

            Console.WriteLine("第二個多項式");
            result=poly.ShowPoly2();
            poly.Display(result);

            Console.WriteLine(line);
            Console.WriteLine("兩個多項式相加結果");
            result=poly.AddItem();
            poly.Display(result);
            Console.ReadKey();
        }
    }
}
