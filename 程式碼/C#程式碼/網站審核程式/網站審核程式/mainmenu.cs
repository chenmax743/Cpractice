Person person = new Person();
person.name = "nom";
person.SayHi();
person.age = 15;

if(person.isAdult())
{
    Console.WriteLine("歡迎進入");
}
else
{
    Console.WriteLine("滾");
}

