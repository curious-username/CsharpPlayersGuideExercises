//class and method structure ONLY!!!
//Define an arrow class, fields for arrowhead, fletching, length(arrowhead and fletching are good enums)
//allow user to pick arrowhead, fletching, and length
//getcost method to return float 













Arrowhead GetArrowheadType()
{
    Console.WriteLine("Arrowhead type (steel, wood, obsidian): ");
    string input = Console.ReadLine();
    return input switch
    {
        "steel" => Arrowhead.steel,
        "wood" => Arrowhead.wood,
        "obsidian" => Arrowhead.obsidian,
        _ => throw new Exception("Please select steel, wood, or obsidian")
    };
}

Fletching GetFletchingType()
{
    Console.WriteLine("Select a fletching type of plastic, turkey feathers, or goose feathers");
    string input = Console.ReadLine();
    return input switch
    {
        "plastic" => Fletching.plastic,
        "turkey feathers" => Fletching.turkeyFeathers,
        "goose feathers" => Fletching.gooseFeathers,
        _ => throw new Exception("Please select plastic, turkey feathers, or good feathers")
    };
}

float GetLength()
{
    float length = 0;
    while (length < 60 || length > 100)
    {
        Console.WriteLine("Select a length for your arrow between 60 and 100 meters");
        length = Convert.ToSingle(Console.ReadLine());

    }
    return length;
}

class Arrow
{
    public Arrowhead _arrowhead;
    public Fletching _fletching;
    public float _arrowLength;

    Arrow(Arrowhead arrowhead, Fletching fletching, float arrowLength)
    {
        _arrowhead = arrowhead;
        _fletching = fletching;
        _arrowLength = arrowLength;
    }

    float GetCost()
    {
        float arrowheadCost = _arrowhead switch
        {
            Arrowhead.steel => 10,
            Arrowhead.wood => 3,
            Arrowhead.obsidian => 5
        };

        float fletchingCost = _fletching switch
        {
            Fletching.plastic => 10,
            Fletching.turkeyFeathers => 5,
            Fletching.gooseFeathers => 3
        };

        float shaftCost = 0.05f * _arrowLength;
        
        return arrowheadCost + fletchingCost + shaftCost;
    }
}



/*
 * arrowhead - steel:10 gold, wood: 3 gold, obsidian: 5gold
 * fletching - plastic: 10 gold, turkey feathers: 5gold, goose feathers: 3 gold
 * shaft - 0.05g gold per centimeter(between 60 and 100m)
 */








enum Arrowhead { steel, wood, obsidian };
enum Fletching { plastic, turkeyFeathers, gooseFeathers};


//bool _isFirstTimeRunning = true;
//float totalCost = 0.0f;
//// need to use the method in the class to calculate 

//Arrow arrow = GetArrow();
//Console.WriteLine($"That arrow costs {arrow.GetCost()} gold.");



//Arrow GetArrow()
//{
//Arrowhead arrowhead = GetArrowheadType();
//Fletching fletching = GetFletchingType();
//float length = GetLength();

//return new Arrow(arrowhead, fletching, length);
//}

//Arrowhead GetArrowheadType()
//{
//Console.Write("Arrowhead type (steel, wood, obsidian): ");
//string input = Console.ReadLine();
//return input switch
//{
//"steel" => Arrowhead.Steel,
//"wood" => Arrowhead.Wood,
//"obsidian" => Arrowhead.Obsidian
//};
//}

//Fletching GetFletchingType()
//{
//Console.Write("Fletching type (plastic, turkey feather, goose feather): ");
//string input = Console.ReadLine();
//return input switch
//{
//"plastic" => Fletching.Plastic,
//"turkey feather" => Fletching.TurkeyFeathers,
//"goose feather" => Fletching.GooseFeathers
//};
//}

//float GetLength()
//{
//float length = 0;

//while (length < 60 || length > 100)
//{
//Console.Write("Arrow length (between 60 and 100): ");
//length = Convert.ToSingle(Console.ReadLine());
//}

//return length;
//}

//class Arrow
//{
//    public Arrowhead _arrowhead;
//    public Fletching _fletching;
//    public float _length;

//    public Arrow(Arrowhead arrowhead, Fletching fletching, float length)
//    {
//        _arrowhead = arrowhead;
//        _fletching = fletching;
//        _length = length;
//    }

//    public float GetCost()
//    {
//        float arrowheadCost = _arrowhead switch
//        {
//            Arrowhead.Steel => 10,
//            Arrowhead.Wood => 3,
//            Arrowhead.Obsidian => 5
//        };

//        float fletchingCost = _fletching switch
//        {
//            Fletching.Plastic => 10,
//            Fletching.TurkeyFeathers => 5,
//            Fletching.GooseFeathers => 3
//        };

//        float shaftCost = 0.05f * _length;

//        return arrowheadCost + fletchingCost + shaftCost;
//    }
//}

//enum Arrowhead { Steel, Wood, Obsidian }
//enum Fletching { Plastic, TurkeyFeathers, GooseFeathers }