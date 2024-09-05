//if 判斷

bool hungry = true;


if(hungry)
{
    Console.WriteLine("我就去吃飯");
}

//2.
//如果 今天有下雨
//      我就開車去上班
//否則
//  我就走路去上班
bool rain = false;
if (rain)
{
    Console.WriteLine("我就開車去上班");
}
else
{
    Console.WriteLine("我就走路去上班");
}

/*
    3.
如果 你考100分
    我給你1000
或是如果 你考80分以上
    我給你500
或是如果你考60分以上
    我給你100元
否則
    你給我300元
*/
int scroe =100;

if(scroe== 100)
{
    Console.WriteLine("很棒，給你1000");
}
else if(scroe>=80)
{
    Console.WriteLine("給你500");
}
else if(scroe>=60)
{
    Console.WriteLine("給你100");
}
else
{
    Console.WriteLine("給我300");
}

/*
 4
    如果你考100 且 今天有下雨
我給你1000
    否則 你給我100
*/
int scroe1 = 90;
bool rainy = false ;
if (scroe1==100 && rainy)
{
    Console.WriteLine("我給你1000");
}
else
{
    Console.WriteLine("給我100");
}

/*
 5
如果 你沒有考100分 或 今天沒有下雨
    我給你1000
否則 
    你給我100
*/

int scroe2 = 10;
bool rainy1 = false ;

if (scroe2==100 || rainy1)
{
    Console.WriteLine("我給你1000");
}
else
{
    Console.WriteLine("你給我100");
}

/*
 *5
 如果 你沒有考100分 或 今天沒有下雨
我給你1000
否則
你給我100
*/

int score3 = 90;
bool rainy3 = true;

if (score3 != 100 || !rainy3)
{
    Console.WriteLine("把一千拿來");
}
else
{
    Console.WriteLine("塊給我100");
}