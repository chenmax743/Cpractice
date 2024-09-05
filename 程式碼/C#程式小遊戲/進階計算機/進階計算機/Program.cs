//進階計算機

Console.Write("輸入第一個數字:");
double num1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("輸入要做得運算:");
string opper =Console.ReadLine();

Console.WriteLine("輸入第二個數:");
double num2 = Convert.ToDouble(Console.ReadLine());

if (opper == "+")
{
    Console.WriteLine(num1 + num2);
}
else if (opper == "-") 
{
    Console.WriteLine(num1 - num2);
}

else if (opper == "*") 
{
    Console.WriteLine(num1 * num2);
}

else if (opper == "/") 
{
    Console.WriteLine(num1 / num2);
}
else
{
    Console.WriteLine("不合法的運算");
}


