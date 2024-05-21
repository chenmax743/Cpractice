using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Title = "Skynet";
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WindowHeight = 40;

        Console.WriteLine("Hello,what's your name");
        Console.ForegroundColor= ConsoleColor.Yellow;
        Console.ReadLine();
        Console.ForegroundColor=ConsoleColor.Blue;
        Console.WriteLine("My name is RTX-4090 \nIm a AI sent from the future to destroy mankind");
       
        Console.WriteLine("What is your name");
        Console.ForegroundColor=ConsoleColor.Yellow;
        Console.ReadLine();
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Cool! Mine is destruction");
        Console.ReadKey();
    }
}
