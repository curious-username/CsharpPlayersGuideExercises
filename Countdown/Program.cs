

int CountDown(int number)
{
    if (number == 0) return 0;
    Console.WriteLine(number);
    return CountDown(number - 1);
}

Console.WriteLine("It's the final countdown!");
CountDown(10);
Console.WriteLine(0);
Console.WriteLine("YEAAAHHHHHHHHH");