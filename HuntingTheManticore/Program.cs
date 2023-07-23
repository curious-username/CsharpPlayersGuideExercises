<<<<<<< HEAD
﻿

/*
 * 
 * Use different colors for different types of messages
 * 
// first user will pilot the manticore(10 health)
    //secretly establish how far the Manticore from the city, range 0 to 100
    //screen clears
    

//second user will play city defense (15 health)
    //player will guess where the manticor is. if below the guessed number too short, higher than the number, too far, hit will take points away
    //normal fire 1 point
    //multiple of 3 fire blast, 3 dmg (%3)
    //multiple of 5 electric blast, 5 dmg (%5)
    //if both, 10 dmg
    //if not distroyed, city 1 dmg
*/



int manticorLife = 10;
int manticorRange;
int cityHealth = 15;
int currentTurn = 0;
int playerGuess;
int cannonDmg = 0;



Console.WriteLine("Player 1, please enter how far the manitcor is");
manticorRange = Convert.ToInt32(Console.ReadLine());
Console.Clear();
Console.WriteLine("Player 2, it is your turn");
Console.WriteLine(new string('-', 20));

while (true)
{
    currentTurn++;
    
    int CannonDmg(int currentRound)
    {
        int dmg;
        if(currentRound % 3 == 0 || currentRound % 5 == 0)
        {
            dmg = 3;
            return dmg;
        }
        else if(currentRound % 5 == 0 && currentRound % 3 == 0)
        {
            dmg = 10;
            return dmg;
        }
        else {
            dmg = 1;
            return dmg;
        }
    }

    cannonDmg = CannonDmg(currentTurn);

    void CannonRoutine()
    {
        int cannonRange;    
        cannonRange = Convert.ToInt32(Console.ReadLine());
        if(cannonRange <= manticorRange) { }
        // enter number
        //return number
        // if logic method

        
    }


    void CityStatus()
    {
        Console.WriteLine($"STATUS: Round {currentTurn} City: {cityHealth}/15 Manticore: {manticorLife}/10");
        Console.WriteLine($"The cannon is expected to deal {cannonDmg} this round");
        Console.Write("Enter desired cannon range: ");
        CannonRoutine();

    }


    
}

/*
 SAMPLE UI:
    Player 2, it is your turn
    ----
    STATUS: Round 1 City: 15/15 Manticore: 10/10
    The cannon is expected to deal 1 damage this round
    Enter desired cannon range: [player enters number]
    That round [OVERSHOT, OR FELL SHORT] of the target. [OR] [was a DIRECT HIT].
 */
=======
﻿int cityLife = 15;
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


>>>>>>> 6b83557fd61eae0d2c7471437e5ce775b10abba2
