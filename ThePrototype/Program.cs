byte user1Answer;
byte user2Answer;

Console.Title = "The Prototype";
Console.WriteLine("User 1, enter a number between 0 and 100: ");

while (true)
{    
    user1Answer = Convert.ToByte(Console.ReadLine());
    
    if(user1Answer < 0 || user1Answer > 100)
    {
        Console.WriteLine("Enter a value between 0 and 100");
    }
    else
    {
        Console.WriteLine("Press any key to continue");
        Console.ReadKey(true);
        Console.Clear();
        break;
    }
}

Console.WriteLine("User 2, guess the number between 0 and 100");

while (true)
{
    user2Answer = Convert.ToByte(Console.ReadLine());

    if(user2Answer > user1Answer)
    {
        Console.WriteLine($"{user2Answer} is too high");
    }
    else if(user2Answer < user1Answer)
    {
        Console.WriteLine($"{user2Answer} is too low");
    }
    else if(user2Answer == user1Answer)
    {
        Console.WriteLine("You guessed the number!");
        break;
    }
    else
    {
        Console.WriteLine("Invalid number, select a number between 0 and 100");

    }



}