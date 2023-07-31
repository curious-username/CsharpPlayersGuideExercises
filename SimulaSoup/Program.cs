string food = "";
string seasoning = "";
string ingredient = "";

bool isIngredientPresent = false;
bool isIngredientAdded = false;

int count = 0;




void Recipe((food, ingredient, seasoning) soup)
{

}

void MainMenu()
{
    Console.WriteLine("Welcome to the Soup Maker");
    Console.WriteLine("Select one type, what ingredients you want, and the flavor you are achieving\n");
    Console.WriteLine("Select an option to start your creation");
    Console.WriteLine("1.) Food");
    Console.WriteLine("2.) Ingredients");
    Console.WriteLine("3.) Seasoning");
    Console.WriteLine("4.) Create Food");
    Console.WriteLine("5.) Exit");
    Console.WriteLine("Select an option");

    string value = Console.ReadLine();
    
    if(value == "1") { FoodMenu(); }
    else if(value == "2") { IngredientsMenu(); }
    else if(value == "3") { SeasoningMenu(); }
    else if(value == "4") { CreateFood(); }
    else if(value == "5") { System.Environment.Exit(1); }
    else
    {
        Console.WriteLine("\nPlease select a valid choice. Select 1, 2, or 3 \n");
        MainMenu();
    }
        MainMenu();
}

    

void FoodMenu()
{
    Console.WriteLine("Please select a food option");
    Console.WriteLine("1 for soup, 2 for stew and 3 for gumbo");
    Console.WriteLine("What would you like to make?");
    
    string choice = Console.ReadLine();

    if (choice == "1") { food = " Soup"; }
    else if (choice == "2") { food = " Stew"; }
    else if (choice == "3") { food = " Gumbo"; }
    
    else 
    {
    Console.WriteLine("Please select a valid choice. Select 1, 2, or 3 ");
    FoodMenu();
    }

    Console.WriteLine($"You selected {food}.\n");
    MainMenu();
}

void IngredientsMenu()
{
    Console.WriteLine("Please select ingredients for your food");
    Console.WriteLine("1 - Mushrooms, 2 - Chicken, 3 - Carrots, 4 - Potatoes 5 - Done");
    Console.WriteLine("What would you like to add to your food?");
    
    string choice = Console.ReadLine();

    if (choice == "1") { choice = " Mushrooms"; }
    else if (choice == "2") { choice = " Chicken"; }
    else if (choice == "3") { choice = " Carrots"; }
    else if (choice == "4") { choice = " Potatoes"; }
    else if (choice == "5") { MainMenu(); }
    else
    {
        Console.WriteLine("Please select a valid choice. Select 1, 2, 3, 4, or 5 \n");
        IngredientsMenu();
    }
    ingredient = choice;
    MainMenu();
}

void SeasoningMenu()
{
    Console.WriteLine("Please select a desired taste for your food");
    Console.WriteLine("1 - Spicy, 2 - Salty, 3 - Sweet");
    Console.WriteLine("What kind of flavor do you want?");
    string choice = Console.ReadLine();

    if (choice == "1") { seasoning = " Spicy"; }
    else if (choice == "2") { seasoning = " Salty"; }
    else if (choice == "3") { seasoning = " Sweet"; }

    else
    {
        Console.WriteLine("Please select a valid choice. Select 1, 2, or 3 ");
        SeasoningMenu();
    }

    Console.WriteLine($"You selected {seasoning}.\n");
    MainMenu();

}

void CreateFood()
{
    if(food == null)
    {
        Console.WriteLine("\nPlease select a food\n");
        FoodMenu();
    }
    else if(ingredient == null)
    {
        Console.WriteLine($"\nPlease select ingredients for your {food}\n");
        IngredientsMenu();
    }
    else if(seasoning == null)
    {
        Console.WriteLine("\nPlease select a seasoning.\n");
        SeasoningMenu();
    }
    else
    {
        //sweet chicken gumbo as an example.
        (string, string, string) finalRecipe = (seasoning, ingredient, food);
        Console.WriteLine(finalRecipe.Item1 + finalRecipe.Item2 + finalRecipe.Item3 + "\n");
    
    }
    
}

MainMenu();

enum food{soup, stew, gumbo}

enum ingredient{mushrooms, chicken, carrots, potatoes}

enum seasoning{spicy, salty, sweet}