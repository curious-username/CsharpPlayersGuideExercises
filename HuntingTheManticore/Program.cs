int cityLife = 15;
int manticoreLife = 10;
int round = 0;
int manticoreDistance;
int cannonDmg;
int cannonRange = 0;

void GameStart()
{
    Console.Write("Player 1, how far away from the city do you want to station the Manticor? " +
        "Select from 0 to 100: ");
    manticoreDistance = Convert.ToInt32(Console.ReadLine());

    if (manticoreDistance < 0)
    {
        Console.WriteLine("Number too low, please enter a number between 0 to 100");
    }
    else if(manticoreDistance > 100)
    {
        Console.WriteLine("Number too high, please enter a number between 0 to 100");
    }
    else
    {
        Console.Clear();
        return;
    }    
    
    GameStart();
    
}

GameStart();


int CalculateCannonDmg()
{
    if (round % 3 == 0 && round % 5 == 0)
    {
        return 10;
    }
    else if (round % 3 == 0 || round % 5 == 0)
    {
        return 3;
    }
    else
    {
        return 1;
    }
}

string CannonDistance()
{
    if (cannonRange < manticoreDistance)
    {
        cityLife--;
        return "FELL SHORT";
    }
    else if (cannonRange > manticoreDistance)
    {
        cityLife--;
        return "OVERSHOT";
    }
    else
    {
        cityLife--;
        manticoreLife--;
        return "DIRECT HIT";
    }
}

void StatusText()
{
    Console.WriteLine($"STATUS: Round: {round} City: {cityLife}/15 Mantircore: {manticoreLife}/10");
    Console.WriteLine($"The cannon is expected to deal {cannonDmg} this round. ");
}

void PlayerInput()
{
    var temp = Console.ReadLine();
    cannonRange = Convert.ToInt32(temp);
    if (cannonRange < 0 || cannonRange > 100)
    {
        Console.Write($"Enter desired cannon range: ");
        Console.WriteLine("Enter a value between 0 and 100");
        PlayerInput();
    }
    else
    {
        Console.WriteLine($"\nThat round {CannonDistance()} the target");
        return;
    }
}

void GameLogic()
{
    round++;
    Console.WriteLine(new string('-', 10));
    cannonDmg = CalculateCannonDmg();
    StatusText();
    PlayerInput();    
    
}

Console.WriteLine("Player 2, it is your turn.");





while (true)
{

    if (cityLife == 0)
    {
        Console.WriteLine("The city has fallen! You lose");
        break;
    }
    else if (manticoreLife == 0)
    {
        Console.WriteLine("You won! You have saved the city!");
        break;
    }
    else
    {

        GameLogic();
        
    }
    
    
    
 

}


