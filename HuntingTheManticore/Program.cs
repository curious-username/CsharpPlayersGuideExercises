

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