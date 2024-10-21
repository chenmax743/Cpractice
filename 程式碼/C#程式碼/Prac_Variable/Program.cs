using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prac_Variable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[,] credit =
            //{
            //    {85,78,66,229},
            //    {95,88,79,262 },
            //    {84,76,67,227 },
            //    {81,73,54,208 }
            //};
            //string[] Subjects = {"國文","英文","數學","總分"};
            //Console.WriteLine();

            //for (int i = 0; i < Subjects.Length; i++)
            //{
            //    Console.Write($"{Subjects[i],-4}");
            //}
            //Console.WriteLine();

            //for (int i = 0; i < credit.GetLength(0); i++)
            //{

            //    for (int j = 0; j < credit.GetLength(1); j++)
            //    {
            //        Console.Write($"{credit[i, j],-6}");                   
            //    }
            //    Console.WriteLine();
            //}


            //int[,] sparse = new int[5, 5]
            //{
            //    {0,0,0,27,0 },
            //    {0,0,13,0,0 },
            //    {0,41,0,0,36 },
            //    {52,0,9,0,0 },
            //    {0,0,0,18,0 }
            //};
            //int rows = sparse.GetLength(0);
            //int cols = sparse.GetLength(1);
            //int nonZero = 0;


            //Console.WriteLine("稀疏陣列");
            //for (int j = 0; j < rows; j++)
            //{
            //    for (int k = 0; k < cols; k++)
            //    {
            //        Console.Write($"{sparse[j, k],3}");
            //        if (sparse[j, k] != 0)
            //            nonZero += 1;
            //    }
            //    Console.WriteLine();
            //}

            //int index = 1;
            //int[,] matrix = new int[8, 3];
            //matrix[0, 0] = rows;
            //matrix[0, 1] = cols;
            //matrix[0, 2] = nonZero;

            //for (int j = 0; j < rows; j++)
            //{
            //    for (int k = 0; k < cols; k++)
            //    {
            //        if (sparse[j, k] != 0)
            //        {
            //            matrix[index, 0] = j;
            //            matrix[index, 1] = k;
            //            matrix[index, 2] = sparse[j, k];
            //            index += 1;
            //        }
            //    }
            //}

            //Console.WriteLine("\n壓縮後的稀疏陣列");
            //for (int j = 0; j < nonZero + 1; j++)
            //{
            //    for (int k = 0; k < 3; k++)

            //    Console.Write($"{matrix[j, k],4}|");

            //    Console.WriteLine();

            //}
            //Console.ReadKey();


            int[,] sparce = new int[5, 6]
            {
                {0,0,24,0,0,0},
                {0,0,0,35,0,0},
                {17,0,0,0,0,58},
                {0,0,0,0,43,0},
                {0,62,0,0,0,0,}
            };

            int Row=sparce.GetLength(0);
            int Col=sparce.GetLength(1);
            int nonZero = 0;

            Console.WriteLine("稀疏陣列");
            for(int i=0;i<Row;i++) 
            {
                for(int j=0;j<Col;j++)
                {
                    Console.Write($"{sparce[i, j],3}");
                    if (sparce[i, j] != 0) ;
                    nonZero += 1;
                }
                Console.WriteLine();
            }


            int index = 1;
            int [,]matrix = new int[7, 3];
            matrix[0,0] = Row;
            matrix[0,1] = Col;
            matrix[0,2]=nonZero;

            for(int i=0;i<Row; i++)
            {
                for (int j=0;j<Col; j++)
                {
                    if (sparce[i, j] != 0)
                    {
                        matrix[index,0] = i;
                        matrix[index,1]=j;
                        matrix[index,2] = sparce[i, j];
                        index++;
                    }
                }
            }

            Console.WriteLine("壓縮後的索引值") ;
            for(int i=0;i<nonZero+1;i++)
            {
                for (int j = 0; j < 3; j++)
                Console.Write($"{matrix[i,j],3}|");
                Console.WriteLine();
            }
            Console.ReadKey();













            Console.ReadLine();
        }
    }
}
