bool _isFirstTimeRunning = true;
float totalCost = 0.0f;
// need to use the method in the class to calculate 

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


string ArrowHead()
{
    string arrowhead;

    Console.WriteLine("Starting with the arrowhead what do you want?");
    Console.WriteLine("1 for steel, 2 for wood, or 3 for obsidian");
    arrowhead = Console.ReadLine();
    if (arrowhead == "1") { arrowhead = "Steel"; totalCost += 10.0f; }
    else if (arrowhead == "2") { arrowhead = "Wood"; totalCost += 3.0f; }
    else if (arrowhead == "3") { arrowhead = "Obsidian";totalCost += 5.0f; }
    else
    {
        Console.WriteLine("Please make a valid selection");
        ArrowHead();
    }
    
    return arrowhead;
}

int Shaft()
{
    float shaft;
    

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
            shaft = Convert.ToInt32(answer);
            totalCost += shaft * 0.05f;
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
    if (fletching == "1") { fletching = "Plastic"; totalCost += 10.0f; }
    else if (fletching == "2") { fletching = "Turkey Feathers"; totalCost += 5.0f; }
    else if (fletching == "3") { fletching = "Goose Feathers"; totalCost += 3.0f; }
    else
    {
        Console.WriteLine("Please make a valid selection");
        ArrowHead();
    }
    return fletching;
}

void ArrowMaker()
{
    Arrow a = new Arrow(ArrowHead(), Shaft(), Fletching());

    Console.WriteLine(a.GetArrowhead());
    Console.WriteLine(a.GetFletching());
    Console.WriteLine(a.GetShaft());



}
ArrowMaker();
class Arrow
{
    private string arrowhead = "undefined";
    private int shaft = 0;
    private string fletching = "undefined";


    public Arrow(string arrowhead, int shaft, string fletching)
    {
        this.arrowhead = arrowhead;
        this.shaft = shaft;
        this.fletching = fletching;
    }

    public string GetArrowhead() => arrowhead; 
    public int GetShaft() => shaft;
    public string GetFletching() => fletching;

    public void PrintMessage()
    {
        Console.WriteLine($"You have created an arrow with {this.arrowhead}, {this.shaft}, {this.fletching}");
    }

    public float GetPrice(float total)
    {
        Console.WriteLine($"Your total price is ");
        return 1.1f;
    }
    

        /*
         * arrowheads: steel = 10 gold, wood costs 3 gold, obsidian costs 5 gold, 
         * shaft: 0.05 gold per cm
         * fletching: turkey feathers = 10 gold, turkey feathers = 5 gold, goose feathers = 3 gold
         * three seperate methods to build total, use get cost to make the calculation
         */


    
}

