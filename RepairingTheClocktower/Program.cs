



while(true)
{
    Console.WriteLine("Please enter a number");
    int choice = Convert.ToInt32(Console.ReadLine());

    if (choice % 2 == 0 && choice != 666)
    {
        Console.WriteLine("Tick");
    }
    else if(choice == 666)
    {
        break;
    }
    else
    {
        Console.WriteLine("Tock");
    }
}

