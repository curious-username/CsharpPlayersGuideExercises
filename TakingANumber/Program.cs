




int AskForNumber(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int text = AskForNumber("How old are you?");
Console.WriteLine("You are " + text + " years old.");

int AskForNumberInRange(string text, int min, int max)
{
    Console.WriteLine($"{text} {min} and {max}");
    while (true)
    {
        int playerAnswer = Convert.ToInt32(Console.ReadLine());
        if (playerAnswer <= min)
        {
            Console.WriteLine("Too small, it must be between min and max values");
        }
        else if (playerAnswer >= max)
        {
            Console.WriteLine("Too large, it must be between min and max values");
        }
        else
        {
            
            return playerAnswer;
        }
    }
    
}

int answer = AskForNumberInRange("Please enter a number between ", 10, 20);
Console.WriteLine($"You have entered {answer}");