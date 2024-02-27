//猜數字遊戲

int secret_num = 100;
int guess;
int guess_count = 0;
int guess_limit = 3;
bool win = false;

do
{
    Console.WriteLine("請輸入猜測號碼");
    guess = Convert.ToInt32(Console.ReadLine());
    guess_count++;

    if (guess > secret_num)
    {
        Console.WriteLine("小一點");
    }
    else if (guess < secret_num)
    {
        Console.WriteLine("大一點");
    }
    else
    {
        Console.WriteLine("恭喜猜對!");
        win = true;
    }
}
while (guess != secret_num && guess_count<guess_limit);

if(!win)
{
    Console.WriteLine("你輸了");
}
