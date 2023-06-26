/*
There are watchtowers in the region around Consolas that can alert you when an enemy is spotted. 
With some help from you, they can tell which direction the enemy is from the watchtower

     x<0| x=0| x>0
    ____________
y>0 | NW | N | NE
y=0 | W  | ! | E
y<0 | SW | S | SE


*/

int x;
int y;
int enemyX;
int enemyY; 


Console.WriteLine("Enter an X value");
x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter a Y value");
y = Convert.ToInt32(Console.ReadLine()); 

if(x < 0)
{
    if(y > 0)
    {
        Console.WriteLine("The enemy is North West of here");
    }
    else if(y < 0)
    {
        Console.WriteLine("The enemy is South West of here");
    }
    else
    {
        Console.WriteLine("The enemy is West of here");
    }
}
else if (x == 0)
{
    if (y > 0)
    {
        Console.WriteLine("The enemy is North of here");
    }
    else if (y < 0)
    {
        Console.WriteLine("The enemy is South of here");
    }
    else
    {
        Console.WriteLine("The enemy is here!");
    }
}
else if (x > 0)
{
    if (y > 0)
    {
        Console.WriteLine("The enemy is North East of here");
    }
    else if (y < 0)
    {
        Console.WriteLine("The enemy is South East of here");
    }
    else
    {
        Console.WriteLine("The enemy is East of here");
    }
}

