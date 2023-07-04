

Console.Title = "The Magic Cannon";


for(int i = 1; i <= 100; i++)
{
    

    if(i % 5 == 0 && i % 3 == 0)
    {
        Console.WriteLine(i + ": Fire Electric Blast");
        
    }
    else if(i % 3 == 0) 
    {
        Console.WriteLine(i + ":  Fire");
        
    }
    else if( i % 5 == 0)
    {
        Console.WriteLine(i + ":  Electric");
        
    }
    else
    {
        Console.WriteLine(i + ":  Normal");
        
    }

    Console.WriteLine($"Currently {i} cranks");
    Console.ReadKey(true);
}