//猜數字遊戲

int secret_num = 100;
int guess;

do
{
    Console.WriteLine("請輸入猜測號碼");
    guess = Convert.ToInt32(Console.ReadLine());

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
    }
}
while (guess != secret_num);
