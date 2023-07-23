/*TO DO: Fix input, doesn't work
 * try enums as input checks instead of the string checks
 */
ChestState current = ChestState.Close;
string playerChoice;


void Game()
{
    playerChoice = "empty";
    Console.Write($"The chest is {current}. What do you want to do? Open, Close, Lock or Unlock.  ");
    playerChoice = Console.ReadLine();
    GameLogic();



}
void GameLogic()
{
        if (playerChoice == "Open")
        {
            ChestOpen();
        }
        else if (playerChoice == "Close")
        {
            ChestClose();
        }
        else if (playerChoice == "Lock")
        {
            ChestLock();
        }
        else if (playerChoice == "Unlock")
        {
            ChestUnlock();
        }
        else
        {
            Game();
        }
    }

void ChestOpen()
{
    if(current == ChestState.Open) 
    {
        Console.WriteLine("The chest is already open");
    }
    else if(current == ChestState.Close)
    {
        current = ChestState.Open;

    }
    else if(current == ChestState.Lock)
    {
        Console.WriteLine("You must unlock the chest before opening it");
    }
    else if(current == ChestState.Unlock)
    {
        current = ChestState.Open;
    }
}

void ChestClose()
{
    if (current == ChestState.Open)
    {
        current = ChestState.Close;
    }
    else if (current == ChestState.Close)
    {
        Console.WriteLine("The Chest is already closed");
    }
    else if (current == ChestState.Lock)
    {
        Console.WriteLine("The chest is currently locked and closed.");
    }
    else if (current == ChestState.Unlock)
    {
        Console.WriteLine("The chest is currently closed, but unlocked");
    }

}
void ChestLock()
{
    if (current == ChestState.Open)
    {
        Console.WriteLine("You must unlock the chest before opening");
    }
    else if (current == ChestState.Close)
    {
        current = ChestState.Lock;
    }
    else if (current == ChestState.Lock)
    {
        Console.WriteLine("The chest is already locked");
    }
    else if(current == ChestState.Unlock)
    {
        current = ChestState.Lock;
    }
}

void ChestUnlock()
{
    if (current == ChestState.Open)
    {
        Console.WriteLine("The chest is already unlocked and open");
    }
    else if (current == ChestState.Close)
    {
        Console.WriteLine("The chest is currently unlocked, but closed");
    }
    else if (current == ChestState.Lock)
    {
        current = ChestState.Unlock;
    }
    else if (current == ChestState.Unlock)
    {
        Console.WriteLine("The chest is already unlocked");
    }

}

while (true)
{
    Game();
}



enum ChestState
{
    Open,
    Close,
    Lock,
    Unlock
}

