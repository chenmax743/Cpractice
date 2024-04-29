using System;
namespace My_PROGRAM
{
    class My_PROGRAM
    {
        static void Main(string[]args)
        {
            int number1;
            int number2;

            Console.Write("Input a number: ");

            number1 =Convert.ToInt32(Console.ReadLine());

            Console.Write("Input a second number: ");
            number2 = Convert.ToInt32(Console.ReadLine());

            int result = number1+number2;
            Console.WriteLine("The result is "+ result);

            Console.ReadKey();
        }
    }
    
}