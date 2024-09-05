// class object 類別 物件 //using  //method
using Animal.QQ;
using System;
Person person1 = new Person();
person1.height = 170.5;
person1.name = "小黑";
person1.age = 12;
person1.SayHi();
if(person1.isAdult())
{
    Console.WriteLine("請進");
}
else
{
    Console.WriteLine("滾");
}

Person person2 = new Person();
person2.height = 165.5;
person2.name = "小169";
person2.age = 65;
person2.SayHi();
person2.isAdult();
if (person2.isAdult())
{
    Console.WriteLine("請進");
}
else
{
    Console.WriteLine("滾");
}

Console.WriteLine(person1.Add(8, 5,"QWQ"));