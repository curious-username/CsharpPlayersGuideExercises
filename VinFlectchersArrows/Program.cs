bool _isFirstTimeRunning = true;





void MainMenu()
{
    if (_isFirstTimeRunning)
    {
        Console.WriteLine("I am Vin Fletcher, a skilled arrow maker.");
        _isFirstTimeRunning=false;
    }
    Console.WriteLine("The arrow has three parts. The arrowhead, shaft, and fletching.");
    ArrowMaker();


}
void ArrowMaker()
{
    Arrow arrow = new Arrow(ArrowHead(), Shaft(), Fletching());
    
    
    


}

string ArrowHead()
{
    string arrowhead;

    Console.WriteLine("Starting with the arrowhead what do you want?");
    Console.WriteLine("1 for steel, 2 for wood, or 3 for obsidian");
    arrowhead = Console.ReadLine();
    if (arrowhead == "1") { arrowhead = "Steel"; }
    else if (arrowhead == "2") { arrowhead = "Wood"; }
    else if (arrowhead == "3") { arrowhead = "Obsidian"; }
    else
    {
        Console.WriteLine("Please make a valid selection");
        ArrowHead();
    }

    return arrowhead;
}

int Shaft()
{
    string shaft;

    Console.WriteLine("Next we select the shaft length.");
    Console.WriteLine("Enter a value between 60 and 100");
    do
    {
        string answer = Console.ReadLine();
        if (Convert.ToInt32(answer) > 100 || Convert.ToInt32(answer) < 60)
        {
            Console.WriteLine("Please enter a value between 60 and 100");
        }
        else
        {
            shaft = answer;
            break;
        }
    } while (true);
    
    return Convert.ToInt32(shaft);
}

string Fletching()
{
    string fletching;

    Console.WriteLine("Lastly select a fletching");
    Console.WriteLine("1 for Plastic, 2 for Turkey Feathers, or 3 for Goose Feathers");
    fletching = Console.ReadLine();
    if (fletching == "1") { fletching = "Plastic"; }
    else if (fletching == "2") { fletching = "Turkey Feathers"; }
    else if (fletching == "3") { fletching = "Goose Feathers"; }
    else
    {
        Console.WriteLine("Please make a valid selection");
        ArrowHead();
    }
    return fletching;
}


class Arrow
{
    string arrowhead = "undefined";
    int shaft = 0;
    string fletching = "undefined";

    public Arrow(string arrowhead, int shaft, string fletching)
    {
        this.arrowhead = arrowhead;
        this.shaft = shaft;
        this.fletching = fletching;
    }    

    void PrintMessage()
    {
        Console.WriteLine($"You have created an arrow with {this.arrowhead}, {this.shaft}, {this.fletching}");
    }

    float GetCost()
    {
        float steel = 10f;
        float wood = 3f;
        float bosidian = 5f;
        float shaft = 0.05f;
        float plastic = 10f;
        float turkeyFeathers = 5f;
        float goodFeathers = 3f;

        


        /*
         * arrowheads: steel = 10 gold, wood costs 3 gold, obsidian costs 5 gold, 
         * shaft: 0.05 gold per cm
         * fletching: turkey feathers = 10 gold, turkey feathers = 5 gold, goose feathers = 3 gold
         */


    }
}

