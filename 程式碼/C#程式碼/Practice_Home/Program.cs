using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Home
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            string[] names = { "Rowena", "Robin", "Bao" };
            foreach (string Name in names)
            {
                Console.WriteLine(Name);
            }

            Console.ReadLine();

        }
    }
}

